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
    public partial class FrmOduncIslemleri : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmOduncIslemleri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnErkekOduncEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Odunc (ErkekUyeID,KitapID,AlisT,VerisT) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtErkekID.Text);
            komut.Parameters.AddWithValue("@p2", TxtErkekKitapID.Text);
            komut.Parameters.AddWithValue("@p3", MskErkekAlis.Text);
            komut.Parameters.AddWithValue("@p4", MskErkekVeris.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();


            
        }

        private void BtnKadinOduncEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Odunc (KadinUyeID,KitapID,AlisT,VerisT) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKadinID.Text);
            komut.Parameters.AddWithValue("@p2", TxtKadinKitapID.Text);
            komut.Parameters.AddWithValue("@p3", MskKadinAlis.Text);
            komut.Parameters.AddWithValue("@p4", MskKadinVeris.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
