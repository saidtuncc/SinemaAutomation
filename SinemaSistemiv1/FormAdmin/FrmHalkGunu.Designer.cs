namespace SinemaSistemiv1.FormAdmin
{
    partial class FrmHalkGunu
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
            ComboxGunSecin = new ComboBox();
            lblGunSeciniz = new Label();
            lblFiyat = new Label();
            NumFiyatBelirle = new NumericUpDown();
            BtnKaydet = new Button();
            lblhalkgunuBelirle = new Label();
            ((System.ComponentModel.ISupportInitialize)NumFiyatBelirle).BeginInit();
            SuspendLayout();
            // 
            // ComboxGunSecin
            // 
            ComboxGunSecin.FormattingEnabled = true;
            ComboxGunSecin.Location = new Point(178, 139);
            ComboxGunSecin.Name = "ComboxGunSecin";
            ComboxGunSecin.Size = new Size(151, 28);
            ComboxGunSecin.TabIndex = 0;
            // 
            // lblGunSeciniz
            // 
            lblGunSeciniz.AutoSize = true;
            lblGunSeciniz.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGunSeciniz.Location = new Point(40, 138);
            lblGunSeciniz.Name = "lblGunSeciniz";
            lblGunSeciniz.Size = new Size(116, 25);
            lblGunSeciniz.TabIndex = 1;
            lblGunSeciniz.Text = "Gün seçiniz ;";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFiyat.Location = new Point(96, 199);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(60, 25);
            lblFiyat.TabIndex = 2;
            lblFiyat.Text = "Fiyat ;";
            // 
            // NumFiyatBelirle
            // 
            NumFiyatBelirle.Location = new Point(178, 197);
            NumFiyatBelirle.Name = "NumFiyatBelirle";
            NumFiyatBelirle.Size = new Size(150, 27);
            NumFiyatBelirle.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKaydet.Location = new Point(189, 260);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(116, 42);
            BtnKaydet.TabIndex = 5;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // lblhalkgunuBelirle
            // 
            lblhalkgunuBelirle.AutoSize = true;
            lblhalkgunuBelirle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblhalkgunuBelirle.Location = new Point(76, 47);
            lblhalkgunuBelirle.Name = "lblhalkgunuBelirle";
            lblhalkgunuBelirle.Size = new Size(370, 31);
            lblhalkgunuBelirle.TabIndex = 6;
            lblhalkgunuBelirle.Text = "H A L K  G Ü N Ü  B E L İ R L E M E";
            // 
            // FrmHalkGunu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(lblhalkgunuBelirle);
            Controls.Add(BtnKaydet);
            Controls.Add(NumFiyatBelirle);
            Controls.Add(lblFiyat);
            Controls.Add(lblGunSeciniz);
            Controls.Add(ComboxGunSecin);
            Name = "FrmHalkGunu";
            Text = "Halk Günü Belirleme";
            Load += FrmHalkGunu_Load;
            ((System.ComponentModel.ISupportInitialize)NumFiyatBelirle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboxGunSecin;
        private Label lblGunSeciniz;
        private Label lblFiyat;
        private NumericUpDown NumFiyatBelirle;
        private Button BtnKaydet;
        private Label lblhalkgunuBelirle;
    }
}