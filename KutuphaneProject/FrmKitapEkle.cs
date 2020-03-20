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
    public partial class FrmKitapEkle : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(TxtKitapAd.Text);
            listBox1.Items.Add(TxtYazar.Text);
            listBox1.Items.Add(TxtSayfa.Text);
            listBox1.Items.Add(TxtTur.Text);

            SqlCommand komut = new SqlCommand("insert into Kitaplar (KitapAd,Yazar,Sayfa,Tur) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut.Parameters.AddWithValue("@p3", TxtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", TxtTur.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();

        }
    }
}
