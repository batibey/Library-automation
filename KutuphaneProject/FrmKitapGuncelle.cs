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
    public partial class FrmKitapGuncelle : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmKitapGuncelle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Kitaplar set KitapAd=@p1,Yazar=@p3,Sayfa=@p4,Tur=@p5 where KitapID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKitapID.Text);
            komut.Parameters.AddWithValue("@p3", TxtYazar.Text);
            komut.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            komut.Parameters.AddWithValue("@p5", TxtTur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT GÜNCELLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
