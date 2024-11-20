using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormCalisan
{
    public partial class FrmOdeme : Form
    {
        private int _totalAmount;

        public FrmOdeme(int totalAmount)
        {
            InitializeComponent();
            _totalAmount = totalAmount;
            lblTutar.Text = $"{totalAmount} TL";
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {

        }

        private void BtnOdemeYap_Click_1(object sender, EventArgs e)
        {
            string krediKartiNumarasi = txtKrediKartiNumarasi.Text;
            string sonKullanmaTarihi = txtSonKullanmaTarihi.Text;
            string cvv = txtCVV.Text;
            string kartIsim = txtKartIsim.Text;

            if (string.IsNullOrWhiteSpace(krediKartiNumarasi) ||
                krediKartiNumarasi.Length != 16 || 
                !krediKartiNumarasi.All(char.IsDigit)) 
            {
                MessageBox.Show("Geçerli bir kredi kartı numarası girin. 16 haneli olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(sonKullanmaTarihi) ||
                !System.Text.RegularExpressions.Regex.IsMatch(sonKullanmaTarihi, @"^(0[1-9]|1[0-2])\/?([0-9]{2})$")) 
            {
                MessageBox.Show("Geçerli bir son kullanma tarihi girin. Örn: 02/24", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(cvv) ||
                cvv.Length != 3 ||
                !cvv.All(char.IsDigit)) 
            {
                MessageBox.Show("Geçerli bir CVV girin. 3 haneli olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(kartIsim))
            {
                MessageBox.Show("Lütfen kart üzerindeki ismi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Ödeme başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

    }

}
