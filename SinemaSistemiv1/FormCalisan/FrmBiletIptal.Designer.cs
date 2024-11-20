namespace SinemaSistemiv1.FormCalisan
{
    partial class FrmBiletIptal
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
            label1 = new Label();
            txtBiletId = new TextBox();
            BtnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(65, 119);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "Bilet ID giriniz :";
            // 
            // txtBiletId
            // 
            txtBiletId.Location = new Point(230, 119);
            txtBiletId.Name = "txtBiletId";
            txtBiletId.Size = new Size(125, 27);
            txtBiletId.TabIndex = 1;
            // 
            // BtnIptal
            // 
            BtnIptal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnIptal.Location = new Point(230, 175);
            BtnIptal.Name = "BtnIptal";
            BtnIptal.Size = new Size(105, 40);
            BtnIptal.TabIndex = 2;
            BtnIptal.Text = "İptal";
            BtnIptal.UseVisualStyleBackColor = true;
            BtnIptal.Click += BtnIptal_Click;
            // 
            // FrmBiletIptal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 352);
            Controls.Add(BtnIptal);
            Controls.Add(txtBiletId);
            Controls.Add(label1);
            Name = "FrmBiletIptal";
            Text = "FrmBiletIptal";
            Load += FrmBiletIptal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBiletId;
        private Button BtnIptal;
    }
}