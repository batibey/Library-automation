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

namespace KutuphaneProject
{
    public partial class FrmGirisler : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmErkekGiris fr = new FrmErkekGiris();
            fr.Show();
            //this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris fr = new FrmPersonelGiris();
            fr.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmKadinGiris fr = new FrmKadinGiris();
            fr.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeOl fr = new FrmUyeOl();
            fr.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPersonelKayit fr = new FrmPersonelKayit();
            fr.Show();
        }
    }
}
