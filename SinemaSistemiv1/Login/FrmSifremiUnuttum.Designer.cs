namespace SinemaSistemiv1.Login
{
    partial class FrmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttum));
            lblEpostaSifreUnuttum = new Label();
            txtEpostaSifreUnuttum = new TextBox();
            BtnGeriSifreUnuttum = new Button();
            lblSifremiUnuttumSifremiunuttum = new Label();
            BtnGonderSifremiUnuttum = new Button();
            SuspendLayout();
            // 
            // lblEpostaSifreUnuttum
            // 
            lblEpostaSifreUnuttum.AutoSize = true;
            lblEpostaSifreUnuttum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEpostaSifreUnuttum.Location = new Point(59, 82);
            lblEpostaSifreUnuttum.Name = "lblEpostaSifreUnuttum";
            lblEpostaSifreUnuttum.Size = new Size(72, 23);
            lblEpostaSifreUnuttum.TabIndex = 8;
            lblEpostaSifreUnuttum.Text = "E-posta:";
            lblEpostaSifreUnuttum.Click += lblEpostaSifreUnuttum_Click;
            // 
            // txtEpostaSifreUnuttum
            // 
            txtEpostaSifreUnuttum.Location = new Point(149, 81);
            txtEpostaSifreUnuttum.Name = "txtEpostaSifreUnuttum";
            txtEpostaSifreUnuttum.Size = new Size(154, 27);
            txtEpostaSifreUnuttum.TabIndex = 11;
            txtEpostaSifreUnuttum.TextChanged += txtEpostaSifreUnuttum_TextChanged;
            // 
            // BtnGeriSifreUnuttum
            // 
            BtnGeriSifreUnuttum.Image = (Image)resources.GetObject("BtnGeriSifreUnuttum.Image");
            BtnGeriSifreUnuttum.Location = new Point(12, 12);
            BtnGeriSifreUnuttum.Name = "BtnGeriSifreUnuttum";
            BtnGeriSifreUnuttum.Size = new Size(67, 39);
            BtnGeriSifreUnuttum.TabIndex = 15;
            BtnGeriSifreUnuttum.UseVisualStyleBackColor = true;
            BtnGeriSifreUnuttum.Click += BtnGeriSifreUnuttum_Click;
            // 
            // lblSifremiUnuttumSifremiunuttum
            // 
            lblSifremiUnuttumSifremiunuttum.AutoSize = true;
            lblSifremiUnuttumSifremiunuttum.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifremiUnuttumSifremiunuttum.Location = new Point(107, 14);
            lblSifremiUnuttumSifremiunuttum.Name = "lblSifremiUnuttumSifremiunuttum";
            lblSifremiUnuttumSifremiunuttum.Size = new Size(259, 37);
            lblSifremiUnuttumSifremiunuttum.TabIndex = 17;
            lblSifremiUnuttumSifremiunuttum.Text = "ŞİFREMİ UNUTTUM";
            lblSifremiUnuttumSifremiunuttum.Click += lblSifremiUnuttumSifremiunuttum_Click;
            // 
            // BtnGonderSifremiUnuttum
            // 
            BtnGonderSifremiUnuttum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGonderSifremiUnuttum.Location = new Point(178, 126);
            BtnGonderSifremiUnuttum.Name = "BtnGonderSifremiUnuttum";
            BtnGonderSifremiUnuttum.Size = new Size(94, 36);
            BtnGonderSifremiUnuttum.TabIndex = 18;
            BtnGonderSifremiUnuttum.Text = "Gönder";
            BtnGonderSifremiUnuttum.UseVisualStyleBackColor = true;
            BtnGonderSifremiUnuttum.Click += BtnGonderSifremiUnuttum_Click;
            // 
            // FrmSifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 281);
            Controls.Add(BtnGonderSifremiUnuttum);
            Controls.Add(lblSifremiUnuttumSifremiunuttum);
            Controls.Add(BtnGeriSifreUnuttum);
            Controls.Add(txtEpostaSifreUnuttum);
            Controls.Add(lblEpostaSifreUnuttum);
            Name = "FrmSifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            Load += FrmSifremiUnuttum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEpostaSifreUnuttum;
        private TextBox txtEpostaSifreUnuttum;
        private Button BtnGeriSifreUnuttum;
        private Label lblSifremiUnuttumSifremiunuttum;
        private Button BtnGonderSifremiUnuttum;
    }
}