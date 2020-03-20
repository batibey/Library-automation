namespace KutuphaneProject
{
    partial class FrmErkekDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErkekDetay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapID = new System.Windows.Forms.TextBox();
            this.BtnKayitEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.MskAlisT = new System.Windows.Forms.MaskedTextBox();
            this.MskVerisT = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(911, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID:";
            // 
            // TxtKitapID
            // 
            this.TxtKitapID.Location = new System.Drawing.Point(137, 83);
            this.TxtKitapID.Name = "TxtKitapID";
            this.TxtKitapID.Size = new System.Drawing.Size(154, 31);
            this.TxtKitapID.TabIndex = 2;
            // 
            // BtnKayitEkle
            // 
            this.BtnKayitEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKayitEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKayitEkle.Location = new System.Drawing.Point(137, 351);
            this.BtnKayitEkle.Name = "BtnKayitEkle";
            this.BtnKayitEkle.Size = new System.Drawing.Size(154, 49);
            this.BtnKayitEkle.TabIndex = 7;
            this.BtnKayitEkle.Text = "EKLE";
            this.BtnKayitEkle.UseVisualStyleBackColor = false;
            this.BtnKayitEkle.Click += new System.EventHandler(this.BtnKayitEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "SON  EKLENEN";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(390, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 304);
            this.listBox1.TabIndex = 10;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Location = new System.Drawing.Point(137, 28);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 29);
            this.TxtID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(98, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Veriş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Alış Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tür: ";
            // 
            // TxtTur
            // 
            this.TxtTur.Location = new System.Drawing.Point(137, 200);
            this.TxtTur.Name = "TxtTur";
            this.TxtTur.Size = new System.Drawing.Size(154, 31);
            this.TxtTur.TabIndex = 4;
            this.TxtTur.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar: ";
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(137, 144);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(154, 31);
            this.TxtYazar.TabIndex = 3;
            // 
            // MskAlisT
            // 
            this.MskAlisT.Location = new System.Drawing.Point(137, 253);
            this.MskAlisT.Name = "MskAlisT";
            this.MskAlisT.Size = new System.Drawing.Size(154, 31);
            this.MskAlisT.TabIndex = 27;
            // 
            // MskVerisT
            // 
            this.MskVerisT.Location = new System.Drawing.Point(137, 308);
            this.MskVerisT.Name = "MskVerisT";
            this.MskVerisT.Size = new System.Drawing.Size(154, 31);
            this.MskVerisT.TabIndex = 28;
            // 
            // FrmErkekDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(940, 413);
            this.Controls.Add(this.MskVerisT);
            this.Controls.Add(this.MskAlisT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnKayitEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTur);
            this.Controls.Add(this.TxtYazar);
            this.Controls.Add(this.TxtKitapID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmErkekDetay";
            this.Text = "FrmErkekDetay";
            this.Load += new System.EventHandler(this.FrmErkekDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapID;
        private System.Windows.Forms.Button BtnKayitEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.MaskedTextBox MskAlisT;
        private System.Windows.Forms.MaskedTextBox MskVerisT;
    }
}