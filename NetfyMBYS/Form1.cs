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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void girisBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=MBYS;Username=postgres;Password=9217";

            using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
            {
                con.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT sifre FROM doktorlar WHERE id = @doktorIdText";
                    cmd.Parameters.AddWithValue("@doktorIdText", Int32.Parse(doktorIdText.Text));

                    string sifre = Convert.ToString(cmd.ExecuteScalar());

                    if (sifre == sifreText.Text)
                    {
                        // sifre değerleri eşit
                        MessageBox.Show("Giriş başarılı!");
                        FrmIslemSayfasi frmIslemSayfasi = new FrmIslemSayfasi();
                        frmIslemSayfasi.Show();
                    }
                    else
                    {
                        // sifre değerleri eşit değil
                        MessageBox.Show("Giriş başarısız! Lütfen bilgilerinizi kontrol ediniz.");
                    }
                }
            }
        }
    }
}
