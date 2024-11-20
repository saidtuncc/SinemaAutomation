namespace SinemaSistemiv1.FormKullanıcı
{
    partial class FrmSatinAlmaGecmisi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewSatinAlmaGecmisi = new DataGridView();
            BtnListele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSatinAlmaGecmisi).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSatinAlmaGecmisi
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSatinAlmaGecmisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSatinAlmaGecmisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSatinAlmaGecmisi.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSatinAlmaGecmisi.Location = new Point(6, 1);
            dataGridViewSatinAlmaGecmisi.Name = "dataGridViewSatinAlmaGecmisi";
            dataGridViewSatinAlmaGecmisi.RowHeadersWidth = 51;
            dataGridViewSatinAlmaGecmisi.Size = new Size(1046, 237);
            dataGridViewSatinAlmaGecmisi.TabIndex = 0;
            // 
            // BtnListele
            // 
            BtnListele.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnListele.Location = new Point(12, 244);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(138, 43);
            BtnListele.TabIndex = 1;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = true;
            BtnListele.Click += BtnListele_Click;
            // 
            // FrmSatinAlmaGecmisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 450);
            Controls.Add(BtnListele);
            Controls.Add(dataGridViewSatinAlmaGecmisi);
            Name = "FrmSatinAlmaGecmisi";
            Text = "Satın Alma Geçmişi";
            Load += FrmSatinAlmaGecmisi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSatinAlmaGecmisi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSatinAlmaGecmisi;
        private Button BtnListele;
    }
}