namespace SinemaSistemiv1.FormKullanıcı
{
    partial class FrmBilgiGuncelleme
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
            lblSifreBilgiGuncelle = new Label();
            txtSifreBilgiGuncelle = new TextBox();
            lblSifreTekrarBilgiGuncelle = new Label();
            txtSifreTekrarBilgiGuncelle = new TextBox();
            lblBilgileriniziGuncelle = new Label();
            BtnGuncelleBlgileriniGuncelle = new Button();
            lblMevcutSifreBilgiGuncelle = new Label();
            txtMevcutSifreBilgiGuncelle = new TextBox();
            SuspendLayout();
            // 
            // lblSifreBilgiGuncelle
            // 
            lblSifreBilgiGuncelle.AutoSize = true;
            lblSifreBilgiGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreBilgiGuncelle.Location = new Point(169, 144);
            lblSifreBilgiGuncelle.Name = "lblSifreBilgiGuncelle";
            lblSifreBilgiGuncelle.Size = new Size(80, 23);
            lblSifreBilgiGuncelle.TabIndex = 9;
            lblSifreBilgiGuncelle.Text = "Yeni Şifre";
            lblSifreBilgiGuncelle.Click += lblSifreBilgiGuncelle_Click;
            // 
            // txtSifreBilgiGuncelle
            // 
            txtSifreBilgiGuncelle.Location = new Point(291, 144);
            txtSifreBilgiGuncelle.Name = "txtSifreBilgiGuncelle";
            txtSifreBilgiGuncelle.PasswordChar = '*';
            txtSifreBilgiGuncelle.Size = new Size(250, 27);
            txtSifreBilgiGuncelle.TabIndex = 10;
            txtSifreBilgiGuncelle.TextChanged += txtSifreBilgiGuncelle_TextChanged;
            // 
            // lblSifreTekrarBilgiGuncelle
            // 
            lblSifreTekrarBilgiGuncelle.AutoSize = true;
            lblSifreTekrarBilgiGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreTekrarBilgiGuncelle.Location = new Point(169, 201);
            lblSifreTekrarBilgiGuncelle.Name = "lblSifreTekrarBilgiGuncelle";
            lblSifreTekrarBilgiGuncelle.Size = new Size(95, 23);
            lblSifreTekrarBilgiGuncelle.TabIndex = 11;
            lblSifreTekrarBilgiGuncelle.Text = "Şifre Tekrar";
            lblSifreTekrarBilgiGuncelle.Click += lblSifreTekrarBilgiGuncelle_Click;
            // 
            // txtSifreTekrarBilgiGuncelle
            // 
            txtSifreTekrarBilgiGuncelle.Location = new Point(291, 197);
            txtSifreTekrarBilgiGuncelle.Name = "txtSifreTekrarBilgiGuncelle";
            txtSifreTekrarBilgiGuncelle.PasswordChar = '*';
            txtSifreTekrarBilgiGuncelle.Size = new Size(250, 27);
            txtSifreTekrarBilgiGuncelle.TabIndex = 12;
            // 
            // lblBilgileriniziGuncelle
            // 
            lblBilgileriniziGuncelle.AutoSize = true;
            lblBilgileriniziGuncelle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBilgileriniziGuncelle.Location = new Point(250, 26);
            lblBilgileriniziGuncelle.Name = "lblBilgileriniziGuncelle";
            lblBilgileriniziGuncelle.Size = new Size(301, 37);
            lblBilgileriniziGuncelle.TabIndex = 13;
            lblBilgileriniziGuncelle.Text = "Bilgilerinizi Güncelleyin";
            lblBilgileriniziGuncelle.Click += lblBilgileriniziGuncelle_Click;
            // 
            // BtnGuncelleBlgileriniGuncelle
            // 
            BtnGuncelleBlgileriniGuncelle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGuncelleBlgileriniGuncelle.Location = new Point(319, 249);
            BtnGuncelleBlgileriniGuncelle.Name = "BtnGuncelleBlgileriniGuncelle";
            BtnGuncelleBlgileriniGuncelle.Size = new Size(163, 43);
            BtnGuncelleBlgileriniGuncelle.TabIndex = 14;
            BtnGuncelleBlgileriniGuncelle.Text = "Güncelle";
            BtnGuncelleBlgileriniGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelleBlgileriniGuncelle.Click += BtnGuncelleBlgileriniGuncelle_Click;
            // 
            // lblMevcutSifreBilgiGuncelle
            // 
            lblMevcutSifreBilgiGuncelle.AutoSize = true;
            lblMevcutSifreBilgiGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMevcutSifreBilgiGuncelle.Location = new Point(169, 93);
            lblMevcutSifreBilgiGuncelle.Name = "lblMevcutSifreBilgiGuncelle";
            lblMevcutSifreBilgiGuncelle.Size = new Size(107, 23);
            lblMevcutSifreBilgiGuncelle.TabIndex = 15;
            lblMevcutSifreBilgiGuncelle.Text = "Mevcut Şifre";
            lblMevcutSifreBilgiGuncelle.Click += lblMevcutSifreBilgiGuncelle_Click;
            // 
            // txtMevcutSifreBilgiGuncelle
            // 
            txtMevcutSifreBilgiGuncelle.Location = new Point(291, 93);
            txtMevcutSifreBilgiGuncelle.Name = "txtMevcutSifreBilgiGuncelle";
            txtMevcutSifreBilgiGuncelle.PasswordChar = '*';
            txtMevcutSifreBilgiGuncelle.Size = new Size(250, 27);
            txtMevcutSifreBilgiGuncelle.TabIndex = 16;
            txtMevcutSifreBilgiGuncelle.TextChanged += txtMevcutSifreBilgiGuncelle_TextChanged;
            // 
            // FrmBilgiGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMevcutSifreBilgiGuncelle);
            Controls.Add(lblMevcutSifreBilgiGuncelle);
            Controls.Add(BtnGuncelleBlgileriniGuncelle);
            Controls.Add(lblBilgileriniziGuncelle);
            Controls.Add(txtSifreTekrarBilgiGuncelle);
            Controls.Add(lblSifreTekrarBilgiGuncelle);
            Controls.Add(txtSifreBilgiGuncelle);
            Controls.Add(lblSifreBilgiGuncelle);
            Name = "FrmBilgiGuncelleme";
            Text = "Bilgi Güncelleme";
            Load += FrmBilgiGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSifreBilgiGuncelle;
        private TextBox txtSifreBilgiGuncelle;
        private Label lblSifreTekrarBilgiGuncelle;
        private TextBox txtSifreTekrarBilgiGuncelle;
        private Label lblBilgileriniziGuncelle;
        private Button BtnGuncelleBlgileriniGuncelle;
        private Label lblMevcutSifreBilgiGuncelle;
        private TextBox txtMevcutSifreBilgiGuncelle;
    }
}