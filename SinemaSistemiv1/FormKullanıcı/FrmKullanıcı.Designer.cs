namespace SinemaSistemiv1
{
    partial class FrmKullanıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanıcı));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BtnFilmSeanslari = new DevExpress.XtraBars.BarButtonItem();
            BtnSatinAlmaGecmisi = new DevExpress.XtraBars.BarButtonItem();
            BtnBilgiGuncelleme = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, BtnFilmSeanslari, BtnSatinAlmaGecmisi, BtnBilgiGuncelleme });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 4;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbonControl1.Size = new Size(991, 183);
            // 
            // BtnFilmSeanslari
            // 
            BtnFilmSeanslari.Caption = "Film Seanları";
            BtnFilmSeanslari.Id = 1;
            BtnFilmSeanslari.ImageOptions.LargeImage = (Image)resources.GetObject("BtnFilmSeanslari.ImageOptions.LargeImage");
            BtnFilmSeanslari.Name = "BtnFilmSeanslari";
            BtnFilmSeanslari.ItemClick += BtnFilmSeanslari_ItemClick;
            // 
            // BtnSatinAlmaGecmisi
            // 
            BtnSatinAlmaGecmisi.Caption = "Satın Alma Geçmişi";
            BtnSatinAlmaGecmisi.Id = 2;
            BtnSatinAlmaGecmisi.ImageOptions.LargeImage = (Image)resources.GetObject("BtnSatinAlmaGecmisi.ImageOptions.LargeImage");
            BtnSatinAlmaGecmisi.Name = "BtnSatinAlmaGecmisi";
            BtnSatinAlmaGecmisi.ItemClick += BtnSatinAlmaGecmisi_ItemClick;
            // 
            // BtnBilgiGuncelleme
            // 
            BtnBilgiGuncelleme.Caption = "Bilgi Güncelleme";
            BtnBilgiGuncelleme.Id = 3;
            BtnBilgiGuncelleme.ImageOptions.LargeImage = (Image)resources.GetObject("BtnBilgiGuncelleme.ImageOptions.LargeImage");
            BtnBilgiGuncelleme.Name = "BtnBilgiGuncelleme";
            BtnBilgiGuncelleme.ItemClick += BtnBilgiGuncelleme_ItemClick;
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
            ribbonPageGroup2.ItemLinks.Add(BtnSatinAlmaGecmisi);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Ayarlar";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(BtnBilgiGuncelleme);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmKullanıcı
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 386);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "FrmKullanıcı";
            Text = "Kullanıcı";
            WindowState = FormWindowState.Maximized;
            Load += FrmKullanıcı_Load;
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
        private DevExpress.XtraBars.BarButtonItem BtnSatinAlmaGecmisi;
        private DevExpress.XtraBars.BarButtonItem BtnBilgiGuncelleme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}