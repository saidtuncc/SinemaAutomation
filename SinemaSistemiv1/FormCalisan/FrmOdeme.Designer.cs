namespace SinemaSistemiv1.FormCalisan
{
    partial class FrmOdeme
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
            txtKrediKartiNumarasi = new TextBox();
            txtSonKullanmaTarihi = new TextBox();
            txtCVV = new TextBox();
            txtKartIsim = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTutar = new Label();
            BtnOdemeYap = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtKrediKartiNumarasi
            // 
            txtKrediKartiNumarasi.Location = new Point(205, 86);
            txtKrediKartiNumarasi.Name = "txtKrediKartiNumarasi";
            txtKrediKartiNumarasi.Size = new Size(125, 27);
            txtKrediKartiNumarasi.TabIndex = 0;
            // 
            // txtSonKullanmaTarihi
            // 
            txtSonKullanmaTarihi.Location = new Point(205, 123);
            txtSonKullanmaTarihi.Name = "txtSonKullanmaTarihi";
            txtSonKullanmaTarihi.Size = new Size(125, 27);
            txtSonKullanmaTarihi.TabIndex = 1;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(205, 172);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(125, 27);
            txtCVV.TabIndex = 2;
            // 
            // txtKartIsim
            // 
            txtKartIsim.Location = new Point(205, 225);
            txtKartIsim.Name = "txtKartIsim";
            txtKartIsim.Size = new Size(125, 27);
            txtKartIsim.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 86);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 4;
            label1.Text = "Kredi Kartı Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 130);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 5;
            label2.Text = "Son Kullanma Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 179);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 6;
            label3.Text = "CVV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 228);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 7;
            label4.Text = "Kart Sahibi İsim Soyisim";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(253, 264);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(46, 20);
            lblTutar.TabIndex = 8;
            lblTutar.Text = "Tutar:";
            // 
            // BtnOdemeYap
            // 
            BtnOdemeYap.Location = new Point(236, 309);
            BtnOdemeYap.Name = "BtnOdemeYap";
            BtnOdemeYap.Size = new Size(94, 29);
            BtnOdemeYap.TabIndex = 9;
            BtnOdemeYap.Text = "Ödeme Yap";
            BtnOdemeYap.UseVisualStyleBackColor = true;
            BtnOdemeYap.Click += BtnOdemeYap_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(117, 28);
            label6.Name = "label6";
            label6.Size = new Size(223, 31);
            label6.TabIndex = 10;
            label6.Text = "Ö D E M E  A L A N I";
            // 
            // FrmOdeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(BtnOdemeYap);
            Controls.Add(lblTutar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKartIsim);
            Controls.Add(txtCVV);
            Controls.Add(txtSonKullanmaTarihi);
            Controls.Add(txtKrediKartiNumarasi);
            Name = "FrmOdeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme Alanı";
            Load += FrmOdeme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKrediKartiNumarasi;
        private TextBox txtSonKullanmaTarihi;
        private TextBox txtCVV;
        private TextBox txtKartIsim;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTutar;
        private Button BtnOdemeYap;
        private Label label6;
    }
}