using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormCalisan
{
    public partial class FrmSatisOnay : Form
    {
        private int _totalAmount;
        public string OdemeTuru { get; private set; }

        public FrmSatisOnay(int totalAmount)
        {
            InitializeComponent();
            _totalAmount = totalAmount;
            lblTutar.Text = $"{totalAmount} TL";
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            OdemeTuru = "Nakit";
            MessageBox.Show("Nakit olarak ödendi.", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            OdemeTuru = "Kredi Kartı";
            MessageBox.Show("Kredi kartından ödendi.", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FrmSatisOnay_Load(object sender, EventArgs e)
        {
            
        }
    }
}
