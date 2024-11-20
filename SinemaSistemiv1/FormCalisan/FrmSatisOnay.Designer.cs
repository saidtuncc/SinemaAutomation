namespace SinemaSistemiv1.FormCalisan
{
    partial class FrmSatisOnay
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
            btnNakit = new Button();
            btnKrediKarti = new Button();
            lblTutar = new Label();
            SuspendLayout();
            // 
            // btnNakit
            // 
            btnNakit.Location = new Point(140, 118);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(94, 29);
            btnNakit.TabIndex = 0;
            btnNakit.Text = "N A K İ T";
            btnNakit.UseVisualStyleBackColor = true;
            btnNakit.Click += btnNakit_Click;
            // 
            // btnKrediKarti
            // 
            btnKrediKarti.Location = new Point(351, 118);
            btnKrediKarti.Name = "btnKrediKarti";
            btnKrediKarti.Size = new Size(173, 29);
            btnKrediKarti.TabIndex = 1;
            btnKrediKarti.Text = "K R E D İ  K A R T I";
            btnKrediKarti.UseVisualStyleBackColor = true;
            btnKrediKarti.Click += btnKrediKarti_Click;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(247, 69);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(46, 20);
            lblTutar.TabIndex = 2;
            lblTutar.Text = "Tutar:";
            // 
            // FrmSatisOnay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 244);
            Controls.Add(lblTutar);
            Controls.Add(btnKrediKarti);
            Controls.Add(btnNakit);
            Name = "FrmSatisOnay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış";
            Load += FrmSatisOnay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNakit;
        private Button btnKrediKarti;
        private Label lblTutar;
    }
}