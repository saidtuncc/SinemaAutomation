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
using SinemaSistemiv1.FormCalisan;
using System.Drawing.Text;


namespace SinemaSistemiv1.FrmCalisan
{
    public partial class FrmCalisan : DevExpress.XtraEditors.XtraForm
    {
        private readonly int _userID;
        public FrmCalisan(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void BtnFilmSeanslari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFilmSeanslariCalisan frm = new FrmFilmSeanslariCalisan(_userID);
            frm.MdiParent = this;
            frm.Show();
        }
        private void BtnSatisRaporu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatisRaporuCalisan frm = new FrmSatisRaporuCalisan(_userID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCalculator frm = new FrmCalculator();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmCalisan_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBiletIptal frm = new FrmBiletIptal();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}