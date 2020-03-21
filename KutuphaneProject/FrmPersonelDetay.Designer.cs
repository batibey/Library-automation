namespace KutuphaneProject
{
    partial class FrmPersonelDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelDetay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKadinID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnKadinKayitSil = new System.Windows.Forms.Button();
            this.BtnKadinKayitEkle = new System.Windows.Forms.Button();
            this.BtnKadinKayitGuncelle = new System.Windows.Forms.Button();
            this.BtnErkekKayitSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnKitapIslemleri = new System.Windows.Forms.Button();
            this.BtnKitapEkle = new System.Windows.Forms.Button();
            this.BtnKitapSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtErkekID = new System.Windows.Forms.TextBox();
            this.BtnErkekKayitEkle = new System.Windows.Forms.Button();
            this.BtnErkekKayitGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1274, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kadın ID: ";
            // 
            // TxtKadinID
            // 
            this.TxtKadinID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKadinID.Location = new System.Drawing.Point(130, 26);
            this.TxtKadinID.Name = "TxtKadinID";
            this.TxtKadinID.Size = new System.Drawing.Size(114, 29);
            this.TxtKadinID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(462, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kadın Kayıtları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1015, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Erkek Kayıtları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 427);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(879, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 427);
            this.dataGridView2.TabIndex = 6;
            // 
            // BtnKadinKayitSil
            // 
            this.BtnKadinKayitSil.BackColor = System.Drawing.SystemColors.Info;
            this.BtnKadinKayitSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKadinKayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKadinKayitSil.ForeColor = System.Drawing.Color.Maroon;
            this.BtnKadinKayitSil.Location = new System.Drawing.Point(12, 73);
            this.BtnKadinKayitSil.Name = "BtnKadinKayitSil";
            this.BtnKadinKayitSil.Size = new System.Drawing.Size(127, 53);
            this.BtnKadinKayitSil.TabIndex = 6;
            this.BtnKadinKayitSil.Text = "Kayıt Sil";
            this.BtnKadinKayitSil.UseVisualStyleBackColor = false;
            this.BtnKadinKayitSil.Click += new System.EventHandler(this.BtnKadinKayitSil_Click);
            // 
            // BtnKadinKayitEkle
            // 
            this.BtnKadinKayitEkle.BackColor = System.Drawing.SystemColors.Info;
            this.BtnKadinKayitEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKadinKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKadinKayitEkle.ForeColor = System.Drawing.Color.Maroon;
            this.BtnKadinKayitEkle.Location = new System.Drawing.Point(82, 140);
            this.BtnKadinKayitEkle.Name = "BtnKadinKayitEkle";
            this.BtnKadinKayitEkle.Size = new System.Drawing.Size(127, 53);
            this.BtnKadinKayitEkle.TabIndex = 8;
            this.BtnKadinKayitEkle.Text = "Kayıt Ekle";
            this.BtnKadinKayitEkle.UseVisualStyleBackColor = false;
            this.BtnKadinKayitEkle.Click += new System.EventHandler(this.BtnKadinKayitEkle_Click);
            // 
            // BtnKadinKayitGuncelle
            // 
            this.BtnKadinKayitGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.BtnKadinKayitGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKadinKayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKadinKayitGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.BtnKadinKayitGuncelle.Location = new System.Drawing.Point(159, 73);
            this.BtnKadinKayitGuncelle.Name = "BtnKadinKayitGuncelle";
            this.BtnKadinKayitGuncelle.Size = new System.Drawing.Size(127, 53);
            this.BtnKadinKayitGuncelle.TabIndex = 7;
            this.BtnKadinKayitGuncelle.Text = "Kayıt Güncelle";
            this.BtnKadinKayitGuncelle.UseVisualStyleBackColor = false;
            this.BtnKadinKayitGuncelle.Click += new System.EventHandler(this.BtnKadinKayitGuncelle_Click);
            // 
            // BtnErkekKayitSil
            // 
            this.BtnErkekKayitSil.BackColor = System.Drawing.SystemColors.Info;
            this.BtnErkekKayitSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnErkekKayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnErkekKayitSil.ForeColor = System.Drawing.Color.Maroon;
            this.BtnErkekKayitSil.Location = new System.Drawing.Point(14, 83);
            this.BtnErkekKayitSil.Name = "BtnErkekKayitSil";
            this.BtnErkekKayitSil.Size = new System.Drawing.Size(127, 53);
            this.BtnErkekKayitSil.TabIndex = 2;
            this.BtnErkekKayitSil.Text = "Kayıt Sil";
            this.BtnErkekKayitSil.UseVisualStyleBackColor = false;
            this.BtnErkekKayitSil.Click += new System.EventHandler(this.BtnErkekKayitSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Miriam Libre", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(353, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(597, 63);
            this.label5.TabIndex = 15;
            this.label5.Text = "PERSONEL  İŞLEM  FORMU";
            // 
            // BtnKitapIslemleri
            // 
            this.BtnKitapIslemleri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKitapIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapIslemleri.Location = new System.Drawing.Point(748, 145);
            this.BtnKitapIslemleri.Name = "BtnKitapIslemleri";
            this.BtnKitapIslemleri.Size = new System.Drawing.Size(117, 55);
            this.BtnKitapIslemleri.TabIndex = 9;
            this.BtnKitapIslemleri.Text = "Kitap Güncelle";
            this.BtnKitapIslemleri.UseVisualStyleBackColor = false;
            this.BtnKitapIslemleri.Click += new System.EventHandler(this.BtnKitapIslemleri_Click);
            // 
            // BtnKitapEkle
            // 
            this.BtnKitapEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapEkle.Location = new System.Drawing.Point(748, 227);
            this.BtnKitapEkle.Name = "BtnKitapEkle";
            this.BtnKitapEkle.Size = new System.Drawing.Size(117, 55);
            this.BtnKitapEkle.TabIndex = 10;
            this.BtnKitapEkle.Text = "Kitap Ekle";
            this.BtnKitapEkle.UseVisualStyleBackColor = false;
            this.BtnKitapEkle.Click += new System.EventHandler(this.BtnKitapEkle_Click);
            // 
            // BtnKitapSil
            // 
            this.BtnKitapSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKitapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapSil.Location = new System.Drawing.Point(748, 305);
            this.BtnKitapSil.Name = "BtnKitapSil";
            this.BtnKitapSil.Size = new System.Drawing.Size(117, 55);
            this.BtnKitapSil.TabIndex = 11;
            this.BtnKitapSil.Text = "Kitap Sil";
            this.BtnKitapSil.UseVisualStyleBackColor = false;
            this.BtnKitapSil.Click += new System.EventHandler(this.BtnKitapSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Erkek ID: ";
            // 
            // TxtErkekID
            // 
            this.TxtErkekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtErkekID.Location = new System.Drawing.Point(132, 32);
            this.TxtErkekID.Name = "TxtErkekID";
            this.TxtErkekID.Size = new System.Drawing.Size(114, 29);
            this.TxtErkekID.TabIndex = 1;
            // 
            // BtnErkekKayitEkle
            // 
            this.BtnErkekKayitEkle.BackColor = System.Drawing.SystemColors.Info;
            this.BtnErkekKayitEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnErkekKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnErkekKayitEkle.ForeColor = System.Drawing.Color.Maroon;
            this.BtnErkekKayitEkle.Location = new System.Drawing.Point(84, 151);
            this.BtnErkekKayitEkle.Name = "BtnErkekKayitEkle";
            this.BtnErkekKayitEkle.Size = new System.Drawing.Size(127, 53);
            this.BtnErkekKayitEkle.TabIndex = 4;
            this.BtnErkekKayitEkle.Text = "Kayıt Ekle";
            this.BtnErkekKayitEkle.UseVisualStyleBackColor = false;
            this.BtnErkekKayitEkle.Click += new System.EventHandler(this.BtnErkekKayitEkle_Click);
            // 
            // BtnErkekKayitGuncelle
            // 
            this.BtnErkekKayitGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.BtnErkekKayitGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnErkekKayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnErkekKayitGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.BtnErkekKayitGuncelle.Location = new System.Drawing.Point(162, 83);
            this.BtnErkekKayitGuncelle.Name = "BtnErkekKayitGuncelle";
            this.BtnErkekKayitGuncelle.Size = new System.Drawing.Size(127, 53);
            this.BtnErkekKayitGuncelle.TabIndex = 3;
            this.BtnErkekKayitGuncelle.Text = "Kayıt Güncelle";
            this.BtnErkekKayitGuncelle.UseVisualStyleBackColor = false;
            this.BtnErkekKayitGuncelle.Click += new System.EventHandler(this.BtnErkekKayitGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnErkekKayitGuncelle);
            this.groupBox1.Controls.Add(this.BtnErkekKayitEkle);
            this.groupBox1.Controls.Add(this.BtnErkekKayitSil);
            this.groupBox1.Controls.Add(this.TxtErkekID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(21, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 217);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Erkek Üye İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnKadinKayitGuncelle);
            this.groupBox2.Controls.Add(this.BtnKadinKayitEkle);
            this.groupBox2.Controls.Add(this.BtnKadinKayitSil);
            this.groupBox2.Controls.Add(this.TxtKadinID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(23, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 214);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kadın Üye İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Font = new System.Drawing.Font("Miriam Libre", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(749, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tedarikçiler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPersonelDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1304, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnKitapSil);
            this.Controls.Add(this.BtnKitapEkle);
            this.Controls.Add(this.BtnKitapIslemleri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelDetay";
            this.Load += new System.EventHandler(this.FrmPersonelDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKadinID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnKadinKayitSil;
        private System.Windows.Forms.Button BtnKadinKayitEkle;
        private System.Windows.Forms.Button BtnKadinKayitGuncelle;
        private System.Windows.Forms.Button BtnErkekKayitSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnKitapIslemleri;
        private System.Windows.Forms.Button BtnKitapEkle;
        private System.Windows.Forms.Button BtnKitapSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtErkekID;
        private System.Windows.Forms.Button BtnErkekKayitEkle;
        private System.Windows.Forms.Button BtnErkekKayitGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}