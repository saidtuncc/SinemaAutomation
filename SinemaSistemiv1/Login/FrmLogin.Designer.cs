namespace SinemaSistemiv1.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            BtnGiris = new Button();
            linkSifremiUnuttum = new LinkLabel();
            lblEposta = new Label();
            lblSifre = new Label();
            lbltxtHosgeldiniz = new Label();
            BtnKayitol = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 449);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(528, 142);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(250, 27);
            txtEposta.TabIndex = 1;
            txtEposta.TextChanged += txtEposta_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(528, 190);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(250, 27);
            txtSifre.TabIndex = 2;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // BtnGiris
            // 
            BtnGiris.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGiris.Location = new Point(541, 281);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(94, 39);
            BtnGiris.TabIndex = 3;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // linkSifremiUnuttum
            // 
            linkSifremiUnuttum.AutoSize = true;
            linkSifremiUnuttum.Location = new Point(661, 220);
            linkSifremiUnuttum.Name = "linkSifremiUnuttum";
            linkSifremiUnuttum.Size = new Size(117, 20);
            linkSifremiUnuttum.TabIndex = 5;
            linkSifremiUnuttum.TabStop = true;
            linkSifremiUnuttum.Text = "Şifremi Unuttum";
            linkSifremiUnuttum.LinkClicked += linkSifremiUnuttum_LinkClicked;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEposta.Location = new Point(443, 142);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(68, 23);
            lblEposta.TabIndex = 6;
            lblEposta.Text = "E-posta";
            lblEposta.Click += lblEposta_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.Location = new Point(454, 197);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(44, 23);
            lblSifre.TabIndex = 7;
            lblSifre.Text = "Şifre";
            lblSifre.Click += lblSifre_Click;
            // 
            // lbltxtHosgeldiniz
            // 
            lbltxtHosgeldiniz.AutoSize = true;
            lbltxtHosgeldiniz.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lbltxtHosgeldiniz.Location = new Point(554, 56);
            lbltxtHosgeldiniz.Name = "lbltxtHosgeldiniz";
            lbltxtHosgeldiniz.Size = new Size(147, 46);
            lbltxtHosgeldiniz.TabIndex = 8;
            lbltxtHosgeldiniz.Text = "Open Sinemasına\r\nHoş Geldiniz..\r\n";
            lbltxtHosgeldiniz.Click += txtHosgeldiniz_Click;
            // 
            // BtnKayitol
            // 
            BtnKayitol.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKayitol.Location = new Point(661, 281);
            BtnKayitol.Name = "BtnKayitol";
            BtnKayitol.Size = new Size(94, 39);
            BtnKayitol.TabIndex = 10;
            BtnKayitol.Text = "Kayıt Ol";
            BtnKayitol.UseVisualStyleBackColor = true;
            BtnKayitol.Click += BtnKayitol_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnKayitol);
            Controls.Add(lbltxtHosgeldiniz);
            Controls.Add(lblSifre);
            Controls.Add(lblEposta);
            Controls.Add(linkSifremiUnuttum);
            Controls.Add(BtnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(panel1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private Button BtnGiris;
        private LinkLabel linkSifremiUnuttum;
        private Label lblEposta;
        private Label lblSifre;
        private Label lbltxtHosgeldiniz;
        private Button BtnKayitol;
    }
}