namespace SinemaSistemiv1.FormKullanıcı
{
    partial class FrmKullaniciTuru
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
            BtnOgrenci = new Button();
            BtnSivil = new Button();
            SuspendLayout();
            // 
            // BtnOgrenci
            // 
            BtnOgrenci.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnOgrenci.Location = new Point(133, 101);
            BtnOgrenci.Name = "BtnOgrenci";
            BtnOgrenci.Size = new Size(105, 46);
            BtnOgrenci.TabIndex = 0;
            BtnOgrenci.Text = "Öğrenci";
            BtnOgrenci.UseVisualStyleBackColor = true;
            BtnOgrenci.Click += BtnOgrenci_Click;
            // 
            // BtnSivil
            // 
            BtnSivil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSivil.Location = new Point(353, 100);
            BtnSivil.Name = "BtnSivil";
            BtnSivil.Size = new Size(106, 47);
            BtnSivil.TabIndex = 1;
            BtnSivil.Text = "Sivil";
            BtnSivil.UseVisualStyleBackColor = true;
            BtnSivil.Click += BtnSivil_Click;
            // 
            // FrmKullaniciTuru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 269);
            Controls.Add(BtnSivil);
            Controls.Add(BtnOgrenci);
            Name = "FrmKullaniciTuru";
            Text = "Koltuk Türü";
            Load += FrmKullaniciTuru_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnOgrenci;
        private Button BtnSivil;
    }
}