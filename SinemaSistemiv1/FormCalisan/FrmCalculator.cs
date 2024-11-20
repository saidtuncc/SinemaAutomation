using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemiv1.FrmCalisan
{
    public partial class FrmCalculator : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                lblSonuc.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (lblSonuc.Text == "0") lblSonuc.Text = "";
            lblSonuc.Text += "0";
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblSonuc.Text);

        }

        private void BtnCıkar_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblSonuc.Text);
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblSonuc.Text);
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(lblSonuc.Text);
        }

        private void BtnEsit_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(lblSonuc.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            lblSonuc.Text = Convert.ToString(sonuc);
        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0";
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
