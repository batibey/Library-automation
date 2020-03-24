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
    public partial class FrmPersonelDetay : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmPersonelDetay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnErkekKayitEkle_Click(object sender, EventArgs e)
        {
            FrmErkekKayit fr = new FrmErkekKayit();
            fr.Show();
        }

        private void BtnKadinKayitEkle_Click(object sender, EventArgs e)
        {
            FrmKadinKayit fr = new FrmKadinKayit();
            fr.Show();
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmKitapEkle fr = new FrmKitapEkle();
            fr.Show();
        }

        private void BtnKitapSil_Click(object sender, EventArgs e)
        {
            FrmKitapSil fr = new FrmKitapSil();
            fr.Show();
        }

        private void BtnKitapIslemleri_Click(object sender, EventArgs e)
        {
            FrmKitapGuncelle fr = new FrmKitapGuncelle();
            fr.Show();
        }

        private void BtnErkekKayitSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from ErkekUyeler where ErkekUyeID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtErkekID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnKadinKayitSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from KadinUyeler where KadinUyeID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKadinID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnErkekKayitGuncelle_Click(object sender, EventArgs e)
        {
            FrmErkekKayitGuncelle fr = new FrmErkekKayitGuncelle();
            fr.Show();

        }

        private void BtnKadinKayitGuncelle_Click(object sender, EventArgs e)
        {
            FrmKadinKayitGuncelle fr = new FrmKadinKayitGuncelle();
            fr.Show();
        }

        private void FrmPersonelDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ErkekUyeler", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("Select * from KadinUyeler", bgl.baglanti());
            daa.Fill(dtt);
            dataGridView1.DataSource = dtt;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //Color c1 = Color.FromArgb(32, 178, 170);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTedarikci fr = new FrmTedarikci();
            fr.Show();
        }

        private void BtnOduncIslemleri_Click(object sender, EventArgs e)
        {
            FrmOduncIslemleri fr = new FrmOduncIslemleri();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOduncKayitlari fr = new FrmOduncKayitlari();
            fr.Show();
        }
    }
}
