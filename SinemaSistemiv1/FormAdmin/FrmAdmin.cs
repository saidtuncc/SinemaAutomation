using DevExpress.Internal;
using DevExpress.XtraEditors;
using SinemaSistemiv1.FormAdmin;
using SinemaSistemiv1.FrmCalisan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemiv1.FrmAdmin
{
    public partial class FrmAdmin : DevExpress.XtraEditors.XtraForm
    {
        private int _kullaniciID;
        public FrmAdmin(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void BtnFilmSeanslariDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFilmSeansDuzenle frm = new FrmFilmSeansDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKullanicilariDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKullanicilariDuzenle frm = new FrmKullanicilariDuzenle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnToplamRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmToplamSatislar frm = new FrmToplamSatislar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKullaniciSatıslari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKullaniciSatislar frm = new FrmKullaniciSatislar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCalisanSatislari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCalisanSatislar frm = new FrmCalisanSatislar(_kullaniciID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCalculator frm = new FrmCalculator();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnHalkGunu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHalkGunu frm = new FrmHalkGunu();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}