using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace NetfyMBYS
{
    public partial class FrmHastaEkleme : Form
    {
        public FrmHastaEkleme()
        {
            InitializeComponent();
        }

        private void hastaEkleBtn_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(Sql.connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO hastalar (tc, ad, soyad, dogum_yeri, dogum_tarihi, adres, telefon, medeni_durum) VALUES (@tc_kimlik_numarasi, @ad, @soyad, @dogum_yeri, @dogum_tarihi, @adres, @telefon, @medeni_durum)";
                    command.Parameters.AddWithValue("@tc_kimlik_numarasi", Int32.Parse(tcText.Text));
                    command.Parameters.AddWithValue("@ad", adiText.Text);
                    command.Parameters.AddWithValue("@soyad", soyadiText.Text);
                    command.Parameters.AddWithValue("@dogum_yeri", dogumYeriText.Text);
                    command.Parameters.AddWithValue("@dogum_tarihi", dogumTarihiText.Text);
                    command.Parameters.AddWithValue("@adres", adresText.Text);
                    command.Parameters.AddWithValue("@telefon", Int32.Parse(telefonText.Text));
                    command.Parameters.AddWithValue("@medeni_durum", evliCheckBox.Checked);
                    
                    command.ExecuteNonQuery();
                    
                    MessageBox.Show("Başarıyla Eklendi");

                    tcText.Clear();
                    adiText.Clear();
                    soyadiText.Clear();
                    dogumYeriText.Clear();
                    dogumTarihiText.Clear();
                    telefonText.Clear();
                    adresText.Clear();
                    evliCheckBox.Checked = false;
                }
            }

        }
    }
}
