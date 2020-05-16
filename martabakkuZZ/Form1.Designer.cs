namespace martabakkuZZ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.btnPesanMenu = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pesanUC1 = new martabakkuZZ.PesanUC();
            this.menuUC1 = new martabakkuZZ.MenuUC();
            this.homeUC1 = new martabakkuZZ.HomeUC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.btnPesanMenu);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 650);
            this.panel1.TabIndex = 3;
            // 
            // Sidepanel
            // 
            this.Sidepanel.AccessibleName = "Sidepanel";
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sidepanel.Location = new System.Drawing.Point(0, 167);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(13, 55);
            this.Sidepanel.TabIndex = 11;
            // 
            // btnPesanMenu
            // 
            this.btnPesanMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanMenu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesanMenu.ForeColor = System.Drawing.Color.White;
            this.btnPesanMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPesanMenu.Image")));
            this.btnPesanMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesanMenu.Location = new System.Drawing.Point(9, 306);
            this.btnPesanMenu.Name = "btnPesanMenu";
            this.btnPesanMenu.Size = new System.Drawing.Size(218, 54);
            this.btnPesanMenu.TabIndex = 8;
            this.btnPesanMenu.Text = "    Pesan";
            this.btnPesanMenu.UseVisualStyleBackColor = true;
            this.btnPesanMenu.Click += new System.EventHandler(this.btnPesanMenu_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(9, 237);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(218, 54);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "    Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(9, 167);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(218, 54);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "    Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Martabakkku - Martabak Daku (Est. 2020)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oleh : Apriyandro Triandito Kusumo, Kelompok 69";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 23);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pesanUC1);
            this.panel3.Controls.Add(this.menuUC1);
            this.panel3.Controls.Add(this.homeUC1);
            this.panel3.Location = new System.Drawing.Point(230, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 470);
            this.panel3.TabIndex = 7;
            // 
            // pesanUC1
            // 
            this.pesanUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pesanUC1.Location = new System.Drawing.Point(0, 0);
            this.pesanUC1.Name = "pesanUC1";
            this.pesanUC1.Size = new System.Drawing.Size(820, 470);
            this.pesanUC1.TabIndex = 2;
            // 
            // menuUC1
            // 
            this.menuUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuUC1.Location = new System.Drawing.Point(3, -1);
            this.menuUC1.Name = "menuUC1";
            this.menuUC1.Size = new System.Drawing.Size(827, 483);
            this.menuUC1.TabIndex = 1;
            // 
            // homeUC1
            // 
            this.homeUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homeUC1.Location = new System.Drawing.Point(3, -1);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(820, 470);
            this.homeUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button btnPesanMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MenuUC menuUC1;
        private HomeUC homeUC1;
        private PesanUC pesanUC1;
    }
}

