using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace en_tr
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        //Datasource=xx ; kısmına kendi sql adresimizi yazıyoruz.
        SqlConnection conn = new SqlConnection("Data Source=K-T;Initial Catalog=dbSozluk;Integrated Security=True");

        public string dil1;
        public string dil2;

        Random rnd = new Random();
        //rastgele kelime id'si bulma
        int s;
        int d = 0, y = 0;
        int t = 60;

        void kelime()
        {
            if (lbldil1.Text == "İngilizce")
            {
                conn.Open();
                txt1.Enabled = false;
                SqlCommand cmd = new SqlCommand("select ingilizce,turkce from sozluk where id=@d1", conn);
                cmd.Parameters.AddWithValue("@d1", label1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt1.Text = dr[0].ToString();
                    lblkarsilik.Text = dr[1].ToString();
                }
                conn.Close();
            }
            if (lbldil1.Text == "Türkçe")
            {
                conn.Open();
                txt1.Enabled = false;
                txt1.Enabled = false;
                SqlCommand cmd = new SqlCommand("select turkce,ingilizce from sozluk where id=@d1", conn);
                cmd.Parameters.AddWithValue("@d1", label1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt1.Text = dr[0].ToString().ToLower();
                    lblkarsilik.Text = dr[1].ToString().ToLower();
                }
                conn.Close();
            }

        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

            label4.Text = t.ToString();
            s = rnd.Next(1, 2490);//random kelime için sayı
            label1.Text = s.ToString();
            lbldil1.Text = dil1;
            lbldil2.Text = dil2;
            kelime();
            timer1.Start();
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            t--;
            label4.Text = t.ToString();
            if (label4.Text == "0")
            {
                txt2.Enabled = false;
            }
            if (label4.Text == "0")
            {
                timer1.Stop();
            }
            if (label4.Text == "0")
            {
                MessageBox.Show("Oyun bitti!\nPuan:" + d * 100);
            }
            if(label4.Text == "0")
            {
                pictureBox2.Visible = true;
                label2.Visible= true;   
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSecim frm = new FrmSecim();
            frm.Show();
            this.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            lbldogru.Text = d.ToString();
            lblyanlis.Text = y.ToString();
            if (txt2.Text == lblkarsilik.Text)
            {

                txt2.Text = "";

                //rastgele kelime id'si bulma
                int s;
                s = rnd.Next(1, 2490);
                label1.Text = s.ToString();
                kelime();

                d++;
                lbldogru.Text = d.ToString();
            }
            else
            {
                txt2.Text = "";
                //rastgele kelime id'si bulma
                int s;
                s = rnd.Next(1, 2490);
                label1.Text = s.ToString();
                kelime();

                y++;
                lblyanlis.Text = y.ToString();
            }
        }
    }
}

