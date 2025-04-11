using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödevson
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        int firstNumber = 0;
        bool isFirstNumberSet = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
            {
                txtSonuc.Clear();
            }
            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void optHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;

            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;

            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            optDurum = true;

            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
                case "%": txtSonuc.Text = (sonuc % Double.Parse(txtSonuc.Text)).ToString(); break;
                case "^": txtSonuc.Text = Math.Pow(sonuc, Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text=="0")
            {
                txtSonuc.Text = "0";

            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";

            }
            if (txtSonuc.Text.Contains("0")||txtSonuc.Text.Contains("1") || txtSonuc.Text.Contains("2") || txtSonuc.Text.Contains("3") || txtSonuc.Text.Contains("4") || txtSonuc.Text.Contains("5") || txtSonuc.Text.Contains("6") || txtSonuc.Text.Contains("7") || txtSonuc.Text.Contains("8") || txtSonuc.Text.Contains("9"))
            {
                txtSonuc.Text += "," ;

            }
            optDurum = false;
            

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text.Length > 0)
            {
                txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1, 1);
            }

            if (txtSonuc.Text == "")
            {
                txtSonuc.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSonuc.Text);
            int a = 0, b = 1, temp;
            lbSonuc.Text = "0";

            for (int i = 1; i < n; i++)
            {
                lbSonuc.Text += ", " + b;
                temp = a + b;
                a = b;
                b = temp;
            }

            txtSonuc.Text = b.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double number = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = Math.Sqrt(number).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            opt = "%";
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Clear();
            lbSonuc.Text = sonuc.ToString() + " % ";
        }

        private void button21_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (string.IsNullOrEmpty(txtSonuc.Text))
                {
                    MessageBox.Show("Lütfen ilk sayıyı giriniz.");
                    return;
                }

               
                firstNumber = int.Parse(txtSonuc.Text);
                isFirstNumberSet = true;

                
                txtSonuc.Clear();
                lbSonuc.Text = firstNumber.ToString() + " ve ikinci sayıyı girin";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

      
        private void button22_Click(object sender, EventArgs e)
        {
            opt = "^";
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Clear();
            lbSonuc.Text = sonuc.ToString() + " ^ ";
        }
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrEmpty(txtSonuc.Text))
                {
                    MessageBox.Show("Lütfen bir sayı giriniz.");
                    return;
                }

                int number = int.Parse(txtSonuc.Text);

                
                if (number < 0)
                {
                    MessageBox.Show("Faktöriyel sadece pozitif tam sayılar için tanımlıdır.");
                    return;
                }

                
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                txtSonuc.Text = result.ToString();
                lbSonuc.Text = number + "! = " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!isFirstNumberSet)
            {
                MessageBox.Show("Önce ilk sayıyı girip EBOB butonuna basın.");
                return;
            }

            try
            {
                
                if (string.IsNullOrEmpty(txtSonuc.Text))
                {
                    MessageBox.Show("Lütfen ikinci sayıyı giriniz.");
                    return;
                }

                int secondNumber = int.Parse(txtSonuc.Text);

                
                int a = firstNumber;
                int b = secondNumber;

                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                txtSonuc.Text = a.ToString(); 
                lbSonuc.Text = "EBOB(" + firstNumber + ", " + secondNumber + ") = " + a;

               
                isFirstNumberSet = false;
                firstNumber = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
