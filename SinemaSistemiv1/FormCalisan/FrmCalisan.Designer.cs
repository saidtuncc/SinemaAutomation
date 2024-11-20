namespace SinemaSistemiv1.FrmCalisan
{
    partial class FrmCalisan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalisan));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BtnFilmSeanslari = new DevExpress.XtraBars.BarButtonItem();
            BtnSatisRaporu = new DevExpress.XtraBars.BarButtonItem();
            BtnCalculator = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, BtnFilmSeanslari, BtnSatisRaporu, BtnCalculator, barButtonItem1 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 6;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbonControl1.Size = new Size(993, 183);
            // 
            // BtnFilmSeanslari
            // 
            BtnFilmSeanslari.Caption = "Film Seansları";
            BtnFilmSeanslari.Id = 1;
            BtnFilmSeanslari.ImageOptions.LargeImage = (Image)resources.GetObject("BtnFilmSeanslari.ImageOptions.LargeImage");
            BtnFilmSeanslari.Name = "BtnFilmSeanslari";
            BtnFilmSeanslari.ItemClick += BtnFilmSeanslari_ItemClick;
            // 
            // BtnSatisRaporu
            // 
            BtnSatisRaporu.Caption = "Satış Raporu";
            BtnSatisRaporu.Id = 3;
            BtnSatisRaporu.ImageOptions.LargeImage = (Image)resources.GetObject("BtnSatisRaporu.ImageOptions.LargeImage");
            BtnSatisRaporu.Name = "BtnSatisRaporu";
            BtnSatisRaporu.ItemClick += BtnSatisRaporu_ItemClick;
            // 
            // BtnCalculator
            // 
            BtnCalculator.Caption = "Hesap Makinesi";
            BtnCalculator.Id = 4;
            BtnCalculator.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCalculator.ImageOptions.LargeImage");
            BtnCalculator.Name = "BtnCalculator";
            BtnCalculator.ItemClick += BtnCalculator_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Bilet İptal";
            barButtonItem1.Id = 5;
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Anasayfa";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(BtnFilmSeanslari);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup4 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Raporlar";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(BtnSatisRaporu);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(BtnCalculator);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmCalisan
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 506);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "FrmCalisan";
            Text = "Çalışan";
            WindowState = FormWindowState.Maximized;
            Load += FrmCalisan_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnFilmSeanslari;
        private DevExpress.XtraBars.BarButtonItem BtnSatisRaporu;
        private DevExpress.XtraBars.BarButtonItem BtnCalculator;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}