namespace SinemaSistemiv1.Login
{
    partial class FrmKayitol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitol));
            lblEpostaKayitOl = new Label();
            lblSifre = new Label();
            lblSifreTekrar = new Label();
            txtEpostaKayitOl = new TextBox();
            txtSifreKayitOl = new TextBox();
            txtSifreTekrar = new TextBox();
            BtnKayitolKayitol = new Button();
            BtnGeri = new Button();
            pictureBox1 = new PictureBox();
            lblKayitOlKayitol = new Label();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEpostaKayitOl
            // 
            lblEpostaKayitOl.AutoSize = true;
            lblEpostaKayitOl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEpostaKayitOl.Location = new Point(406, 142);
            lblEpostaKayitOl.Name = "lblEpostaKayitOl";
            lblEpostaKayitOl.Size = new Size(72, 23);
            lblEpostaKayitOl.TabIndex = 7;
            lblEpostaKayitOl.Text = "E-posta:";
            lblEpostaKayitOl.Click += lblEpostaKayitOl_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.Location = new Point(406, 188);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 8;
            lblSifre.Text = "Şifre:";
            lblSifre.Click += lblSifre_Click;
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreTekrar.Location = new Point(406, 235);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(103, 23);
            lblSifreTekrar.TabIndex = 9;
            lblSifreTekrar.Text = "Şifre Tekrarı:";
            lblSifreTekrar.Click += lblSifreTekrar_Click;
            // 
            // txtEpostaKayitOl
            // 
            txtEpostaKayitOl.Location = new Point(519, 142);
            txtEpostaKayitOl.Name = "txtEpostaKayitOl";
            txtEpostaKayitOl.Size = new Size(154, 27);
            txtEpostaKayitOl.TabIndex = 10;
            txtEpostaKayitOl.TextChanged += txtEpostaKayitOl_TextChanged;
            // 
            // txtSifreKayitOl
            // 
            txtSifreKayitOl.Location = new Point(519, 188);
            txtSifreKayitOl.Name = "txtSifreKayitOl";
            txtSifreKayitOl.PasswordChar = '*';
            txtSifreKayitOl.Size = new Size(154, 27);
            txtSifreKayitOl.TabIndex = 11;
            txtSifreKayitOl.TextChanged += txtSifreKayitOl_TextChanged;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(519, 235);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(154, 27);
            txtSifreTekrar.TabIndex = 12;
            txtSifreTekrar.TextChanged += txtSifreTekrar_TextChanged;
            // 
            // BtnKayitolKayitol
            // 
            BtnKayitolKayitol.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKayitolKayitol.Location = new Point(472, 292);
            BtnKayitolKayitol.Name = "BtnKayitolKayitol";
            BtnKayitolKayitol.Size = new Size(204, 39);
            BtnKayitolKayitol.TabIndex = 13;
            BtnKayitolKayitol.Text = "Kayıt Ol";
            BtnKayitolKayitol.UseVisualStyleBackColor = true;
            BtnKayitolKayitol.Click += BtnKayitolKayitol_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.Image = (Image)resources.GetObject("BtnGeri.Image");
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(67, 39);
            BtnGeri.TabIndex = 14;
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblKayitOlKayitol
            // 
            lblKayitOlKayitol.AutoSize = true;
            lblKayitOlKayitol.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKayitOlKayitol.Location = new Point(519, 14);
            lblKayitOlKayitol.Name = "lblKayitOlKayitol";
            lblKayitOlKayitol.Size = new Size(129, 37);
            lblKayitOlKayitol.TabIndex = 16;
            lblKayitOlKayitol.Text = "KAYIT OL";
            lblKayitOlKayitol.Click += lblKayitOlKayitol_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(406, 103);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 17;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(519, 102);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(154, 27);
            txtKullaniciAdi.TabIndex = 18;
            // 
            // FrmKayitol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 455);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(lblKayitOlKayitol);
            Controls.Add(BtnGeri);
            Controls.Add(BtnKayitolKayitol);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifreKayitOl);
            Controls.Add(txtEpostaKayitOl);
            Controls.Add(lblSifreTekrar);
            Controls.Add(lblSifre);
            Controls.Add(lblEpostaKayitOl);
            Controls.Add(pictureBox1);
            Name = "FrmKayitol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            Load += FrmKayitol_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEpostaKayitOl;
        private Label lblSifre;
        private Label lblSifreTekrar;
        private TextBox txtEpostaKayitOl;
        private TextBox txtSifreKayitOl;
        private TextBox txtSifreTekrar;
        private Button BtnKayitolKayitol;
        private Button BtnGeri;
        private PictureBox pictureBox1;
        private Label lblKayitOlKayitol;
        private Label label1;
        private TextBox txtKullaniciAdi;
    }
}