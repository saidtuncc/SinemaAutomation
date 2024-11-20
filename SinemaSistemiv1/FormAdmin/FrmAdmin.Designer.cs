namespace SinemaSistemiv1.FrmAdmin
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BtnKullanicilariDuzenle = new DevExpress.XtraBars.BarButtonItem();
            BtnToplamRaporlar = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            BtnFilmSeanslariDuzenle = new DevExpress.XtraBars.BarButtonItem();
            BtnKullaniciSatıslari = new DevExpress.XtraBars.BarButtonItem();
            BtnCalisanSatislari = new DevExpress.XtraBars.BarButtonItem();
            BtnCalculator = new DevExpress.XtraBars.BarButtonItem();
            BtnHalkGunu = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            RibbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            BtnKullaniciSatıslar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, BtnKullanicilariDuzenle, BtnToplamRaporlar, barButtonItem6, BtnFilmSeanslariDuzenle, BtnKullaniciSatıslari, BtnCalisanSatislari, BtnCalculator, BtnHalkGunu });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 16;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, RibbonPage2 });
            ribbonControl1.Size = new Size(1097, 183);
            // 
            // BtnKullanicilariDuzenle
            // 
            BtnKullanicilariDuzenle.Caption = "Kullanıcıları Düzenle";
            BtnKullanicilariDuzenle.Id = 3;
            BtnKullanicilariDuzenle.ImageOptions.LargeImage = (Image)resources.GetObject("BtnKullanicilariDuzenle.ImageOptions.LargeImage");
            BtnKullanicilariDuzenle.Name = "BtnKullanicilariDuzenle";
            BtnKullanicilariDuzenle.ItemClick += BtnKullanicilariDuzenle_ItemClick;
            // 
            // BtnToplamRaporlar
            // 
            BtnToplamRaporlar.Caption = "Toplam Raporlar";
            BtnToplamRaporlar.Id = 4;
            BtnToplamRaporlar.ImageOptions.LargeImage = (Image)resources.GetObject("BtnToplamRaporlar.ImageOptions.LargeImage");
            BtnToplamRaporlar.Name = "BtnToplamRaporlar";
            BtnToplamRaporlar.ItemClick += BtnToplamRaporlar_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Çalışan Satışlar";
            barButtonItem6.Id = 6;
            barButtonItem6.Name = "barButtonItem6";
            // 
            // BtnFilmSeanslariDuzenle
            // 
            BtnFilmSeanslariDuzenle.Caption = "Film Seansları Düzenle";
            BtnFilmSeanslariDuzenle.Id = 8;
            BtnFilmSeanslariDuzenle.ImageOptions.LargeImage = (Image)resources.GetObject("BtnFilmSeanslariDuzenle.ImageOptions.LargeImage");
            BtnFilmSeanslariDuzenle.Name = "BtnFilmSeanslariDuzenle";
            BtnFilmSeanslariDuzenle.ItemClick += BtnFilmSeanslariDuzenle_ItemClick;
            // 
            // BtnKullaniciSatıslari
            // 
            BtnKullaniciSatıslari.Caption = "Kullanıcı Satışları";
            BtnKullaniciSatıslari.Id = 10;
            BtnKullaniciSatıslari.ImageOptions.LargeImage = (Image)resources.GetObject("BtnKullaniciSatıslari.ImageOptions.LargeImage");
            BtnKullaniciSatıslari.Name = "BtnKullaniciSatıslari";
            BtnKullaniciSatıslari.ItemClick += BtnKullaniciSatıslari_ItemClick;
            // 
            // BtnCalisanSatislari
            // 
            BtnCalisanSatislari.Caption = "Çalışan Satışları";
            BtnCalisanSatislari.Id = 13;
            BtnCalisanSatislari.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCalisanSatislari.ImageOptions.LargeImage");
            BtnCalisanSatislari.Name = "BtnCalisanSatislari";
            BtnCalisanSatislari.ItemClick += BtnCalisanSatislari_ItemClick;
            // 
            // BtnCalculator
            // 
            BtnCalculator.Caption = "Hesap Makinesi";
            BtnCalculator.Id = 14;
            BtnCalculator.ImageOptions.LargeImage = (Image)resources.GetObject("BtnCalculator.ImageOptions.LargeImage");
            BtnCalculator.Name = "BtnCalculator";
            BtnCalculator.ItemClick += BtnCalculator_ItemClick;
            // 
            // BtnHalkGunu
            // 
            BtnHalkGunu.Caption = "Halk Günü";
            BtnHalkGunu.Id = 15;
            BtnHalkGunu.ImageOptions.LargeImage = (Image)resources.GetObject("BtnHalkGunu.ImageOptions.LargeImage");
            BtnHalkGunu.Name = "BtnHalkGunu";
            BtnHalkGunu.ItemClick += BtnHalkGunu_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup7 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Anasayfa";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(BtnFilmSeanslariDuzenle);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(BtnKullanicilariDuzenle);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(BtnHalkGunu);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // RibbonPage2
            // 
            RibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4, BtnKullaniciSatıslar, ribbonPageGroup5, ribbonPageGroup6 });
            RibbonPage2.Name = "RibbonPage2";
            RibbonPage2.Text = "Raporlar";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(BtnToplamRaporlar);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // BtnKullaniciSatıslar
            // 
            BtnKullaniciSatıslar.ItemLinks.Add(BtnKullaniciSatıslari);
            BtnKullaniciSatıslar.Name = "BtnKullaniciSatıslar";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(BtnCalisanSatislari);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add(BtnCalculator);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 503);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "FrmAdmin";
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnKullanicilariDuzenle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem BtnToplamRaporlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BtnKullaniciSatıslar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnFilmSeanslariDuzenle;
        private DevExpress.XtraBars.BarButtonItem BtnKullaniciSatıslari;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem BtnCalisanSatislari;
        private DevExpress.XtraBars.BarButtonItem BtnCalculator;
        private DevExpress.XtraBars.BarButtonItem BtnHalkGunu;
    }
}