using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _clear;
        private int _sayi1;
        public Form1()
        {
            InitializeComponent();
        }

        private void r1Button_Click(object sender, EventArgs e)// "1" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = ""; 
            {
                ekranLabel.Text += "1";
            }
        }

        private void r2Button_Click(object sender, EventArgs e) // "2" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear= false; 
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "2";
            }
        }

        private void r3Button_Click(object sender, EventArgs e)// "3" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
                
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "3";
            }
        }

        private void r4Button_Click(object sender, EventArgs e)// "4" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "4";
            }
        }

        private void r5Button_Click(object sender, EventArgs e)// "5" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "5";
            }
        }

        private void r6utton_Click(object sender, EventArgs e)// "6" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "6";
            }
        }

        private void r7Button_Click(object sender, EventArgs e)// "7" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "7";
            }
        }

        private void r8Button_Click(object sender, EventArgs e)// "8" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "8";
            }
        }

        private void r9Button_Click(object sender, EventArgs e)// "9" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "9";
            }
        }

        private void r0Button_Click(object sender, EventArgs e)// "0" Rakamını yazdırır.
        {
            if (_clear)
            {
                ekranLabel.Text = "";
                _clear = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            {
                ekranLabel.Text += "0";
            }
        }

        private void toplamaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _clear = true;
            _sayi1 = Convert.ToInt32(ekranLabel.Text);
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _sayi1 + sayi2;
                    break;

                case '-':
                    sonuc = _sayi1 - sayi2;
                    break;

                case 'x':
                    sonuc = _sayi1 * sayi2;
                    break;

                case '/':
                    sonuc = _sayi1 / sayi2;
                    break;
                default:  //eğer default yazmasaydık ve değer atmasaydık sonuc değişkeni hata verir.
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void cıkarmaButton_Click(object sender, EventArgs e) //çıkarma işlemi
        {
            _islem = '-';
            _clear = true;
            _sayi1 = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpmaButton_Click(object sender, EventArgs e) //çarpma işlemi
        {
            _islem = 'x';
            _clear = true;
            _sayi1 = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _clear = true;
            _sayi1 = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e) //ekranı ve işlemleri temizleyecek.
        {
            ekranLabel.Text = "0"; 
        }
    }
}
