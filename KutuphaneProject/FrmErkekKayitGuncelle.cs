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
    public partial class FrmErkekKayitGuncelle : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmErkekKayitGuncelle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update ErkekUyeler set Ad=@p1,Soyad=@p2,Yas=@p3,Tel=@p4 where ErkekUyeID = @p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtYas.Text);
            komut.Parameters.AddWithValue("@p4", MskTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();

        }
    }
}
