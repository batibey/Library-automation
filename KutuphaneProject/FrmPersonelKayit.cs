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
    public partial class FrmPersonelKayit : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmPersonelKayit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnKayitEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel(Ad,Soyad,Yas,Cinsiyet,Tel) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtYas.Text);
            komut.Parameters.AddWithValue("@p4", TxtCinsiyet.Text);
            komut.Parameters.AddWithValue("@p5", MskTel.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
