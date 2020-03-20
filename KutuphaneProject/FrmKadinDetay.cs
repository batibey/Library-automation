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
    public partial class FrmKadinDetay : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmKadinDetay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnKayitEkle_Click(object sender, EventArgs e)
        {
            /*listBox1.Items.Add("Kitap Adı:  " + TxtKitapAd.Text);
            listBox1.Items.Add("Yazar:  " + TxtYazar.Text);
            listBox1.Items.Add("Kitabın Türü:  " + TxtTur.Text);*/
        }

        private void BtnKayitEkle_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kitabın Adı:  " + TxtKitapID.Text);
            listBox1.Items.Add("Yazar:  " + TxtYazar.Text);
            listBox1.Items.Add("Tür:  " + TxtTur.Text);

            SqlCommand komut = new SqlCommand("insert into Odunc (AlisT,VerisT,KadinUyeID,KitapID) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskAlisT.Text);
            komut.Parameters.AddWithValue("@p2", MskVerisT.Text);
            komut.Parameters.AddWithValue("@p3", TxtID.Text);
            komut.Parameters.AddWithValue("@p4", TxtKitapID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
