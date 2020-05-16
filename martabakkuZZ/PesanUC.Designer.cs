namespace martabakkuZZ
{
    partial class PesanUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesanUC));
            this.labelJudul = new System.Windows.Forms.Label();
            this.pictureBoxPesanan = new System.Windows.Forms.PictureBox();
            this.comboBoxMartabak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTelor = new System.Windows.Forms.GroupBox();
            this.checkBoxAbon = new System.Windows.Forms.CheckBox();
            this.checkBoxKornet = new System.Windows.Forms.CheckBox();
            this.checkBoxKejuTelor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTelor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxManis = new System.Windows.Forms.GroupBox();
            this.checkBoxKismis = new System.Windows.Forms.CheckBox();
            this.checkBoxCoklat = new System.Windows.Forms.CheckBox();
            this.checkBoxKejuManis = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxManis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.groupBoxPesanan = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPesanan3 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPesanan2 = new System.Windows.Forms.Label();
            this.labelPesanan1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPesan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesanan)).BeginInit();
            this.groupBoxTelor.SuspendLayout();
            this.groupBoxManis.SuspendLayout();
            this.groupBoxPesanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(357, 39);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(93, 23);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Pesanan";
            // 
            // pictureBoxPesanan
            // 
            this.pictureBoxPesanan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPesanan.Image")));
            this.pictureBoxPesanan.Location = new System.Drawing.Point(31, 106);
            this.pictureBoxPesanan.Name = "pictureBoxPesanan";
            this.pictureBoxPesanan.Size = new System.Drawing.Size(187, 146);
            this.pictureBoxPesanan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesanan.TabIndex = 2;
            this.pictureBoxPesanan.TabStop = false;
            // 
            // comboBoxMartabak
            // 
            this.comboBoxMartabak.FormattingEnabled = true;
            this.comboBoxMartabak.Items.AddRange(new object[] {
            "Telor",
            "Manis"});
            this.comboBoxMartabak.Location = new System.Drawing.Point(277, 121);
            this.comboBoxMartabak.Name = "comboBoxMartabak";
            this.comboBoxMartabak.Size = new System.Drawing.Size(137, 24);
            this.comboBoxMartabak.TabIndex = 4;
            this.comboBoxMartabak.Text = "    ";
            this.comboBoxMartabak.SelectedIndexChanged += new System.EventHandler(this.comboBoxMartabak_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Silahkan pilih jenis martabak yang ingin dipesan";
            // 
            // groupBoxTelor
            // 
            this.groupBoxTelor.Controls.Add(this.checkBoxAbon);
            this.groupBoxTelor.Controls.Add(this.checkBoxKornet);
            this.groupBoxTelor.Controls.Add(this.checkBoxKejuTelor);
            this.groupBoxTelor.Controls.Add(this.label4);
            this.groupBoxTelor.Controls.Add(this.comboBoxTelor);
            this.groupBoxTelor.Controls.Add(this.label3);
            this.groupBoxTelor.Location = new System.Drawing.Point(264, 151);
            this.groupBoxTelor.Name = "groupBoxTelor";
            this.groupBoxTelor.Size = new System.Drawing.Size(509, 101);
            this.groupBoxTelor.TabIndex = 5;
            this.groupBoxTelor.TabStop = false;
            this.groupBoxTelor.Text = "Martabak Telor";
            this.groupBoxTelor.Visible = false;
            this.groupBoxTelor.VisibleChanged += new System.EventHandler(this.groupBoxTelor_VisibleChanged);
            // 
            // checkBoxAbon
            // 
            this.checkBoxAbon.AutoSize = true;
            this.checkBoxAbon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAbon.Location = new System.Drawing.Point(394, 69);
            this.checkBoxAbon.Name = "checkBoxAbon";
            this.checkBoxAbon.Size = new System.Drawing.Size(68, 23);
            this.checkBoxAbon.TabIndex = 6;
            this.checkBoxAbon.Text = "Abon";
            this.checkBoxAbon.UseVisualStyleBackColor = true;
            // 
            // checkBoxKornet
            // 
            this.checkBoxKornet.AutoSize = true;
            this.checkBoxKornet.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKornet.Location = new System.Drawing.Point(313, 69);
            this.checkBoxKornet.Name = "checkBoxKornet";
            this.checkBoxKornet.Size = new System.Drawing.Size(75, 23);
            this.checkBoxKornet.TabIndex = 4;
            this.checkBoxKornet.Text = "Kornet";
            this.checkBoxKornet.UseVisualStyleBackColor = true;
            // 
            // checkBoxKejuTelor
            // 
            this.checkBoxKejuTelor.AutoSize = true;
            this.checkBoxKejuTelor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKejuTelor.Location = new System.Drawing.Point(176, 69);
            this.checkBoxKejuTelor.Name = "checkBoxKejuTelor";
            this.checkBoxKejuTelor.Size = new System.Drawing.Size(131, 23);
            this.checkBoxKejuTelor.TabIndex = 3;
            this.checkBoxKejuTelor.Text = "Keju Mozarella";
            this.checkBoxKejuTelor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tambahan Topping";
            // 
            // comboBoxTelor
            // 
            this.comboBoxTelor.BackColor = System.Drawing.Color.White;
            this.comboBoxTelor.FormattingEnabled = true;
            this.comboBoxTelor.Items.AddRange(new object[] {
            "Biasa(2 Telor)",
            "Spesial(3 Telor)",
            "Istimewa(4 Telor)"});
            this.comboBoxTelor.Location = new System.Drawing.Point(176, 32);
            this.comboBoxTelor.Name = "comboBoxTelor";
            this.comboBoxTelor.Size = new System.Drawing.Size(192, 24);
            this.comboBoxTelor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pilihan Telor";
            // 
            // groupBoxManis
            // 
            this.groupBoxManis.Controls.Add(this.checkBoxKismis);
            this.groupBoxManis.Controls.Add(this.checkBoxCoklat);
            this.groupBoxManis.Controls.Add(this.checkBoxKejuManis);
            this.groupBoxManis.Controls.Add(this.label5);
            this.groupBoxManis.Controls.Add(this.comboBoxManis);
            this.groupBoxManis.Controls.Add(this.label6);
            this.groupBoxManis.Location = new System.Drawing.Point(264, 151);
            this.groupBoxManis.Name = "groupBoxManis";
            this.groupBoxManis.Size = new System.Drawing.Size(503, 101);
            this.groupBoxManis.TabIndex = 6;
            this.groupBoxManis.TabStop = false;
            this.groupBoxManis.Text = "Martabak Manis";
            this.groupBoxManis.Visible = false;
            this.groupBoxManis.VisibleChanged += new System.EventHandler(this.groupBoxManis_VisibleChanged);
            // 
            // checkBoxKismis
            // 
            this.checkBoxKismis.AutoSize = true;
            this.checkBoxKismis.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKismis.Location = new System.Drawing.Point(328, 72);
            this.checkBoxKismis.Name = "checkBoxKismis";
            this.checkBoxKismis.Size = new System.Drawing.Size(68, 23);
            this.checkBoxKismis.TabIndex = 5;
            this.checkBoxKismis.Text = "Kismis";
            this.checkBoxKismis.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoklat
            // 
            this.checkBoxCoklat.AutoSize = true;
            this.checkBoxCoklat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCoklat.Location = new System.Drawing.Point(243, 72);
            this.checkBoxCoklat.Name = "checkBoxCoklat";
            this.checkBoxCoklat.Size = new System.Drawing.Size(76, 23);
            this.checkBoxCoklat.TabIndex = 4;
            this.checkBoxCoklat.Text = "Coklat";
            this.checkBoxCoklat.UseVisualStyleBackColor = true;
            // 
            // checkBoxKejuManis
            // 
            this.checkBoxKejuManis.AutoSize = true;
            this.checkBoxKejuManis.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKejuManis.Location = new System.Drawing.Point(176, 72);
            this.checkBoxKejuManis.Name = "checkBoxKejuManis";
            this.checkBoxKejuManis.Size = new System.Drawing.Size(60, 23);
            this.checkBoxKejuManis.TabIndex = 3;
            this.checkBoxKejuManis.Text = "Keju";
            this.checkBoxKejuManis.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tambahan Topping";
            // 
            // comboBoxManis
            // 
            this.comboBoxManis.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManis.FormattingEnabled = true;
            this.comboBoxManis.Items.AddRange(new object[] {
            "Biasa",
            "Pandan",
            "Taro"});
            this.comboBoxManis.Location = new System.Drawing.Point(176, 32);
            this.comboBoxManis.Name = "comboBoxManis";
            this.comboBoxManis.Size = new System.Drawing.Size(192, 25);
            this.comboBoxManis.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pilihan Adonan";
            // 
            // buttonPesanan
            // 
            this.buttonPesanan.Location = new System.Drawing.Point(426, 268);
            this.buttonPesanan.Name = "buttonPesanan";
            this.buttonPesanan.Size = new System.Drawing.Size(187, 23);
            this.buttonPesanan.TabIndex = 8;
            this.buttonPesanan.Text = "Masukan Pesanan";
            this.buttonPesanan.UseVisualStyleBackColor = true;
            this.buttonPesanan.Visible = false;
            this.buttonPesanan.Click += new System.EventHandler(this.buttonPesanan_Click);
            // 
            // groupBoxPesanan
            // 
            this.groupBoxPesanan.Controls.Add(this.label8);
            this.groupBoxPesanan.Controls.Add(this.label7);
            this.groupBoxPesanan.Controls.Add(this.labelPesanan3);
            this.groupBoxPesanan.Controls.Add(this.Harga);
            this.groupBoxPesanan.Controls.Add(this.label10);
            this.groupBoxPesanan.Controls.Add(this.label9);
            this.groupBoxPesanan.Controls.Add(this.labelPesanan2);
            this.groupBoxPesanan.Controls.Add(this.labelPesanan1);
            this.groupBoxPesanan.Location = new System.Drawing.Point(224, 307);
            this.groupBoxPesanan.Name = "groupBoxPesanan";
            this.groupBoxPesanan.Size = new System.Drawing.Size(593, 100);
            this.groupBoxPesanan.TabIndex = 9;
            this.groupBoxPesanan.TabStop = false;
            this.groupBoxPesanan.Text = "Pesanan Kamu";
            this.groupBoxPesanan.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "-Varian:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "-Jenis Martabak:";
            // 
            // labelPesanan3
            // 
            this.labelPesanan3.AutoSize = true;
            this.labelPesanan3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPesanan3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesanan3.ForeColor = System.Drawing.Color.Blue;
            this.labelPesanan3.Location = new System.Drawing.Point(377, 18);
            this.labelPesanan3.Name = "labelPesanan3";
            this.labelPesanan3.Size = new System.Drawing.Size(14, 19);
            this.labelPesanan3.TabIndex = 5;
            this.labelPesanan3.Text = "-";
            // 
            // Harga
            // 
            this.Harga.AutoSize = true;
            this.Harga.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harga.ForeColor = System.Drawing.Color.Red;
            this.Harga.Location = new System.Drawing.Point(320, 55);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(16, 19);
            this.Harga.TabIndex = 4;
            this.Harga.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(212, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "-Total Harga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(212, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "-Tambahan Topping :";
            // 
            // labelPesanan2
            // 
            this.labelPesanan2.AutoSize = true;
            this.labelPesanan2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesanan2.ForeColor = System.Drawing.Color.Blue;
            this.labelPesanan2.Location = new System.Drawing.Point(83, 55);
            this.labelPesanan2.Name = "labelPesanan2";
            this.labelPesanan2.Size = new System.Drawing.Size(14, 19);
            this.labelPesanan2.TabIndex = 1;
            this.labelPesanan2.Text = "-";
            // 
            // labelPesanan1
            // 
            this.labelPesanan1.AutoSize = true;
            this.labelPesanan1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesanan1.ForeColor = System.Drawing.Color.Blue;
            this.labelPesanan1.Location = new System.Drawing.Point(144, 22);
            this.labelPesanan1.Name = "labelPesanan1";
            this.labelPesanan1.Size = new System.Drawing.Size(14, 19);
            this.labelPesanan1.TabIndex = 0;
            this.labelPesanan1.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonPesan
            // 
            this.buttonPesan.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesan.Location = new System.Drawing.Point(376, 423);
            this.buttonPesan.Name = "buttonPesan";
            this.buttonPesan.Size = new System.Drawing.Size(75, 30);
            this.buttonPesan.TabIndex = 11;
            this.buttonPesan.Text = "Pesan";
            this.buttonPesan.UseVisualStyleBackColor = true;
            this.buttonPesan.Visible = false;
            this.buttonPesan.Click += new System.EventHandler(this.buttonPesan_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(536, 423);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(121, 30);
            this.buttonHapus.TabIndex = 12;
            this.buttonHapus.Text = "Hapus Pesanan";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Visible = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // PesanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.buttonPesanan);
            this.Controls.Add(this.groupBoxManis);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonPesan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxPesanan);
            this.Controls.Add(this.groupBoxTelor);
            this.Controls.Add(this.comboBoxMartabak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPesanan);
            this.Controls.Add(this.labelJudul);
            this.Name = "PesanUC";
            this.Size = new System.Drawing.Size(820, 470);
            this.Load += new System.EventHandler(this.PesanUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesanan)).EndInit();
            this.groupBoxTelor.ResumeLayout(false);
            this.groupBoxTelor.PerformLayout();
            this.groupBoxManis.ResumeLayout(false);
            this.groupBoxManis.PerformLayout();
            this.groupBoxPesanan.ResumeLayout(false);
            this.groupBoxPesanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.PictureBox pictureBoxPesanan;
        private System.Windows.Forms.ComboBox comboBoxMartabak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTelor;
        private System.Windows.Forms.CheckBox checkBoxKejuTelor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTelor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAbon;
        private System.Windows.Forms.GroupBox groupBoxManis;
        private System.Windows.Forms.CheckBox checkBoxKismis;
        private System.Windows.Forms.CheckBox checkBoxCoklat;
        private System.Windows.Forms.CheckBox checkBoxKejuManis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxManis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPesanan;
        private System.Windows.Forms.GroupBox groupBoxPesanan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPesanan3;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPesanan2;
        private System.Windows.Forms.Label labelPesanan1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPesan;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.CheckBox checkBoxKornet;
    }
}
