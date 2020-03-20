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
    public partial class FrmKadinGiris : Form
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmKadinGiris()
        {
            InitializeComponent();
        }

        private void FrmKadinGiris_Load(object sender, EventArgs e)
        {


        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * From KadinUyeler Where KadinUyeID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmKadinDetay fr = new FrmKadinDetay();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
