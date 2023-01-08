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
    public partial class FrmMuayeneOlustur : Form
    {
        public FrmMuayeneOlustur()
        {
            InitializeComponent();
        }

        private void muayeneEkleBtn_Click(object sender, EventArgs e)
        {
            int tc = int.Parse(hastaTcText.Text);
            string tarih = muayeneTarihiText.Text;
            string sikayet = hastaSikayetText.Text;
            string tani = hastaTaniText.Text;
            string tedavi = hastaTedavisiText.Text;
            int doktor_id = int.Parse(doktorCmb.Text);

            using (var connection = new NpgsqlConnection(Sql.connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO muayeneler (tc, tarih, sikayet, tani, tedavi, doktor_id) VALUES (@tc, @tarih, @sikayet, @tani, @tedavi, @doktor_id)";
                    command.Parameters.AddWithValue("@tc", tc);
                    command.Parameters.AddWithValue("@tarih", tarih);
                    command.Parameters.AddWithValue("@sikayet", sikayet);
                    command.Parameters.AddWithValue("@tani", tani);
                    command.Parameters.AddWithValue("@tedavi", tedavi);
                    command.Parameters.AddWithValue("@doktor_id", doktor_id);
                    
                    command.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla Eklendi");

                    hastaTcText.Clear();
                    muayeneTarihiText.Clear();
                    muayeneNoText.Clear();
                    hastaTaniText.Clear();
                    hastaSikayetText.Clear();
                    hastaSikayetText.Clear();
                }
            }


        }

        private void ekleveDevamBtn_Click(object sender, EventArgs e)
        {
            int tc = int.Parse(hastaTcText.Text);
            string tarih = muayeneTarihiText.Text;
            string sikayet = hastaSikayetText.Text;
            string tani = hastaTaniText.Text;
            string tedavi = hastaTedavisiText.Text;
            int doktor_id = int.Parse(doktorCmb.Text);

            using (var connection = new NpgsqlConnection(Sql.connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO muayeneler (tc, tarih, sikayet, tani, tedavi, doktor_id) VALUES (@tc, @tarih, @sikayet, @tani, @tedavi, @doktor_id)";
                    command.Parameters.AddWithValue("@tc", tc);
                    command.Parameters.AddWithValue("@tarih", tarih);
                    command.Parameters.AddWithValue("@sikayet", sikayet);
                    command.Parameters.AddWithValue("@tani", tani);
                    command.Parameters.AddWithValue("@tedavi", tedavi);
                    command.Parameters.AddWithValue("@doktor_id", doktor_id);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla Eklendi");

                    hastaTcText.Clear();
                    muayeneTarihiText.Clear();
                    muayeneNoText.Clear();
                    hastaTaniText.Clear();
                    hastaSikayetText.Clear();
                    hastaSikayetText.Clear();

                    FrmReceteEkrani frmReceteEkrani = new FrmReceteEkrani();
                    frmReceteEkrani.Show();
                }
            }
        }
    }
}
