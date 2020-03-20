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
    public partial class FrmPersonelGiris : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personel Where PersonelID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmPersonelDetay fr = new FrmPersonelDetay();
                //fr.id = TxtID.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı ID Girişi");

            }
            bgl.baglanti().Close();
        }
    }
}

