using DevExpress.XtraEditors;
using SinemaSistemiv1.FormKullanıcı;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemiv1
{
    public partial class FrmKullanıcı : DevExpress.XtraEditors.XtraForm
    {
        private int _kullaniciID;
        public FrmKullanıcı(int kullaniciId)
        {
            _kullaniciID = kullaniciId;
            InitializeComponent();
        }

        private void BtnFilmSeanslari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFilmSeanslarıKullanici frm = new FrmFilmSeanslarıKullanici(_kullaniciID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnSatinAlmaGecmisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatinAlmaGecmisi frm = new FrmSatinAlmaGecmisi(_kullaniciID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnBilgiGuncelleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBilgiGuncelleme frm = new FrmBilgiGuncelleme(_kullaniciID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmKullanıcı_Load(object sender, EventArgs e)
        {

        }
    }
}