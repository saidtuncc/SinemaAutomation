namespace SinemaSistemiv1.FormCalisan
{
    partial class FrmSatisRaporuCalisan
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
            lblTotalSalesAmount = new Label();
            chartControl3 = new DevExpress.XtraCharts.ChartControl();
            lblTopSellingFilm = new Label();
            lblCancelledSales = new Label();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartControl3).BeginInit();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chartControl1.Location = new Point(69, 67);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new Size(539, 368);
            chartControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            chartControl2.Location = new Point(688, 67);
            chartControl2.Name = "chartControl2";
            chartControl2.Size = new Size(568, 368);
            chartControl2.TabIndex = 2;
            // 
            // lblTotalSalesAmount
            // 
            lblTotalSalesAmount.AutoSize = true;
            lblTotalSalesAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalSalesAmount.Location = new Point(93, 459);
            lblTotalSalesAmount.Name = "lblTotalSalesAmount";
            lblTotalSalesAmount.Size = new Size(63, 25);
            lblTotalSalesAmount.TabIndex = 3;
            lblTotalSalesAmount.Text = "label1";
            // 
            // chartControl3
            // 
            chartControl3.Location = new Point(1316, 67);
            chartControl3.Name = "chartControl3";
            chartControl3.Size = new Size(496, 368);
            chartControl3.TabIndex = 4;
            // 
            // lblTopSellingFilm
            // 
            lblTopSellingFilm.AutoSize = true;
            lblTopSellingFilm.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTopSellingFilm.Location = new Point(93, 507);
            lblTopSellingFilm.Name = "lblTopSellingFilm";
            lblTopSellingFilm.Size = new Size(63, 25);
            lblTopSellingFilm.TabIndex = 5;
            lblTopSellingFilm.Text = "label2";
            // 
            // lblCancelledSales
            // 
            lblCancelledSales.AutoSize = true;
            lblCancelledSales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCancelledSales.Location = new Point(93, 558);
            lblCancelledSales.Name = "lblCancelledSales";
            lblCancelledSales.Size = new Size(63, 25);
            lblCancelledSales.TabIndex = 6;
            lblCancelledSales.Text = "label3";
            // 
            // FrmSatisRaporuCalisan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1813, 703);
            Controls.Add(lblCancelledSales);
            Controls.Add(lblTopSellingFilm);
            Controls.Add(chartControl3);
            Controls.Add(lblTotalSalesAmount);
            Controls.Add(chartControl2);
            Controls.Add(chartControl1);
            Name = "FrmSatisRaporuCalisan";
            Text = "FrmSatisRaporuCalisan";
            Load += FrmSatisRaporuCalisan_Load;
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartControl3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private Label lblTotalSalesAmount;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private Label lblTopSellingFilm;
        private Label lblCancelledSales;
    }
}