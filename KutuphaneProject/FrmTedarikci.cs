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
    public partial class FrmTedarikci : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        public FrmTedarikci()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtAdres.Clear();
            TxtId.Clear();
            MskTel.Clear();
            listBox1.Items.Clear();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(TxtAd.Text);
            listBox1.Items.Add(TxtAdres.Text);
            listBox1.Items.Add(MskTel.Text);

            FrmTedarikciEkle fr = new FrmTedarikciEkle();
            fr.Show();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tedarikciler where TedarikciID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Tedarikçi Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void BtnKayitGetir_Click(object sender, EventArgs e)
        {
            FrmTedarikciKayitGetir fr = new FrmTedarikciKayitGetir();
            fr.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tedarikciler set Adı=@p1,Adres=@p2,Tel=@p3 where TedarikciID=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p3", MskTel.Text);
            komut.Parameters.AddWithValue("@p4", TxtId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
