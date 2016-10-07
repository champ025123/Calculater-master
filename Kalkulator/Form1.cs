using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostfixNotation;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        decimal result = 0;
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            ReversePolishNotation r = new ReversePolishNotation();
            result = 0;
            try
            {
                result = r.result(InputField.Text);
                InputField.Text += " = " + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong input");

            }


        }

        private void InitField()
        {
            if (InputField.Text.IndexOf('=') != -1)
            {
                InputField.Text = result.ToString();
            }
        }
        private void OneButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "1";

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "0";

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "8";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text = InputField.Text.Remove(InputField.Text.Length - 1, 1);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "9";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "+";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "-";
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "*";
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "/";
        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "^";
        }

        private void CloseBracketButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += ")";
        }

        private void OpenBracketButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "(";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            InputField.Text = "";
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += ",";
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "cos";
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "sin";
        }

        private void tan_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "tan";
        }

        private void ctan_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "ctan";
        }

        private void log_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "log";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "ln";
        }

        private void ln_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "!";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "sqrt";
        }

        private void tan_Click_1(object sender, EventArgs e)
        {
            InitField();
            InputField.Text += "tan";
        }
    }
}
