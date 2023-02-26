using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace en_tr
{
    public partial class FrmSecim : Form
    {
        public FrmSecim()
        {
            InitializeComponent();
        }

        
        
        private void btntren_Click(object sender, EventArgs e)
        {
            Frmmain frm = new Frmmain();
            frm.dil1 = "Türkçe";
            frm.dil2 = "İngilizce";
            frm.Show();
            this.Hide();
        }

        private void btnentr_Click(object sender, EventArgs e)
        {
            Frmmain frm = new Frmmain();
            frm.dil1 = "İngilizce";
            frm.dil2 = "Türkçe";
            frm.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSecim_Load(object sender, EventArgs e)
        {

        }
    }
}
