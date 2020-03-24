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
    public partial class FrmOduncKayitlari : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public FrmOduncKayitlari()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmOduncKayitlari_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Odunc", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
