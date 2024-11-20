namespace SinemaSistemiv1.FrmAdmin
{
    partial class FrmKullanicilariDuzenle
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
            dataGridViewUser = new DataGridView();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ComBoxRol = new ComboBox();
            BtnEkle = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(12, 12);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(688, 188);
            dataGridViewUser.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(250, 234);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 203);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 203);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "Sifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 203);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 7;
            label3.Text = "Rol";
            // 
            // ComBoxRol
            // 
            ComBoxRol.FormattingEnabled = true;
            ComBoxRol.Location = new Point(439, 233);
            ComBoxRol.Name = "ComBoxRol";
            ComBoxRol.Size = new Size(151, 28);
            ComBoxRol.TabIndex = 9;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(68, 295);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(94, 29);
            BtnEkle.TabIndex = 10;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(68, 362);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 29);
            BtnGuncelle.TabIndex = 11;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(184, 362);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(94, 29);
            BtnSil.TabIndex = 12;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // FrmKullanicilariDuzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnEkle);
            Controls.Add(ComBoxRol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(dataGridViewUser);
            Name = "FrmKullanicilariDuzenle";
            Text = "Kullanıcıları Düzenle";
            Load += FrmKullanicilariDuzenle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox ComBoxRol;
        private Button BtnEkle;
        private Button BtnGuncelle;
        private Button BtnSil;
    }
}