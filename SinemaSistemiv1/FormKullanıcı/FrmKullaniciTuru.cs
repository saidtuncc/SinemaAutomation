using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormKullanıcı
{
    public partial class FrmKullaniciTuru : Form
    {
        public string KullaniciTuru { get; private set; }
        public FrmKullaniciTuru()
        {
            InitializeComponent();
        }

        private void FrmKullaniciTuru_Load(object sender, EventArgs e)
        {

        }

        private void BtnOgrenci_Click(object sender, EventArgs e)
        {
            KullaniciTuru = "ogrenci";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnSivil_Click(object sender, EventArgs e)
        {
            KullaniciTuru = "sivil";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
