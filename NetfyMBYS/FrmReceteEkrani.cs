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
    public partial class FrmReceteEkrani : Form
    {
        public FrmReceteEkrani()
        {
            InitializeComponent();
        }

        private void muayeneSonlandirBtn_Click(object sender, EventArgs e)
        {

            int ilac1_barkod = int.Parse(ilac1Text.Text);
            int ilac2_barkod = int.Parse(ilac2Text.Text);
            int ilac3_barkod = int.Parse(ilac3Text.Text);
            int ilac4_barkod = int.Parse(ilac4Text.Text);
            int ilac5_barkod = int.Parse(ilac5Text.Text);

            int ilac1_miktar = int.Parse(ilacSayisi1Cmb.SelectedItem.ToString());
            int ilac2_miktar = int.Parse(ilacSayisi2Cmb.SelectedItem.ToString());
            int ilac3_miktar = int.Parse(ilacSayisi3Cmb.SelectedItem.ToString());
            int ilac4_miktar = int.Parse(ilacSayisi4Cmb.SelectedItem.ToString());
            int ilac5_miktar = int.Parse(ilacSayisi5Cmb.SelectedItem.ToString());




            using (var connection = new NpgsqlConnection(Sql.connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO receteler (ilac1_barkod, ilac2_barkod, ilac3_barkod, ilac4_barkod, ilac5_barkod, ilac1_miktar, ilac2_miktar, ilac3_miktar, ilac4_miktar, ilac5_miktar) VALUES (@ilac1_barkod, @ilac2_barkod, @ilac3_barkod, @ilac4_barkod, @ilac5_barkod, @ilac1_miktar, @ilac2_miktar, @ilac3_miktar, @ilac4_miktar, @ilac5_miktar)";
                    command.Parameters.AddWithValue("@ilac1_barkod", ilac1_barkod);
                    command.Parameters.AddWithValue("@ilac2_barkod", ilac2_barkod);
                    command.Parameters.AddWithValue("@ilac3_barkod", ilac3_barkod);
                    command.Parameters.AddWithValue("@ilac4_barkod", ilac4_barkod);
                    command.Parameters.AddWithValue("@ilac5_barkod", ilac5_barkod);
                    command.Parameters.AddWithValue("@ilac1_miktar", ilac1_miktar);
                    command.Parameters.AddWithValue("@ilac2_miktar", ilac2_miktar);
                    command.Parameters.AddWithValue("@ilac3_miktar", ilac3_miktar);
                    command.Parameters.AddWithValue("@ilac4_miktar", ilac4_miktar);
                    command.Parameters.AddWithValue("@ilac5_miktar", ilac5_miktar);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Bşarılı Bir Şekilde Eklendi");
                    this.Close();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
