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
    public partial class FrmErkekGiris : Form
    {

        //public string id; -- isim çekmediğimiz için gerek yok (şimdilik).

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmErkekGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmErkekGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From ErkekUyeler Where ErkekUyeID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmErkekDetay fr = new FrmErkekDetay();
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
