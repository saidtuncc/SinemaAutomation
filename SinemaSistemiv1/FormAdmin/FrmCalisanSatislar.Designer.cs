namespace SinemaSistemiv1.FormAdmin
{
    partial class FrmCalisanSatislar
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
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            chartControl2 = new DevExpress.XtraCharts.ChartControl();
            chartControl4 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl4).BeginInit();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.Location = new Point(92, 67);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new Size(532, 351);
            chartControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            chartControl2.Location = new Point(752, 67);
            chartControl2.Name = "chartControl2";
            chartControl2.Size = new Size(532, 351);
            chartControl2.TabIndex = 1;
            // 
            // chartControl4
            // 
            chartControl4.Location = new Point(752, 447);
            chartControl4.Name = "chartControl4";
            chartControl4.Size = new Size(532, 291);
            chartControl4.TabIndex = 3;
            // 
            // FrmCalisanSatislar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 739);
            Controls.Add(chartControl4);
            Controls.Add(chartControl2);
            Controls.Add(chartControl1);
            Name = "FrmCalisanSatislar";
            Text = "FrmCalisanSatislar";
            Load += FrmCalisanSatislar_Load;
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl4).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;

        private DevExpress.XtraCharts.ChartControl chartControl4;
    }
}