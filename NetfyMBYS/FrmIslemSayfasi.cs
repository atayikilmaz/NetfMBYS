using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfyMBYS
{
    public partial class FrmIslemSayfasi : Form
    {
        public FrmIslemSayfasi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void hastaEkleBtn_Click(object sender, EventArgs e)
        {
            FrmHastaEkleme frmHastaEkleme = new FrmHastaEkleme();
            frmHastaEkleme.Show();
            
        }

        private void muayeneOlusturBtn_Click(object sender, EventArgs e)
        {
            FrmMuayeneOlustur frmMuayeneOlustur = new FrmMuayeneOlustur();
            frmMuayeneOlustur.Show();
        }
    }
}
