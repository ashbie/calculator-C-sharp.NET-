using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        private float nombre1 = 0.0f;
        private float nombre2 = 0.0f;
        private float result = 0.0f;
        private string operateur = "+";
        private Boolean minusOperationHappened = false;
        private Boolean plusOperationHappened = false;
        private Boolean multiplyOperationHappened = false;
        private Boolean divideOperationHappened = false;
        private Boolean modulusOperationHappened = false;

        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nombre1 = float.Parse(TextBox.Text);
            TextBox.Clear();
            operateur = "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains("-"))
            {
                TextBox.Text.Trim('-');
            }
            else
            {
                TextBox.Text = "-" + TextBox.Text;
            }
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains(","))
            {
                TextBox.Text += ",";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
        
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            nombre1 = float.Parse(TextBox.Text);
            TextBox.Clear();
            operateur = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            nombre1 = float.Parse(TextBox.Text);
            TextBox.Clear();
            operateur = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            nombre1 = float.Parse(TextBox.Text);
            TextBox.Clear();
            operateur = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            nombre1 = float.Parse(TextBox.Text);
            TextBox.Clear();
            operateur = "*";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operateur)
            {
                case "-":
                    if(minusOperationHappened == false) { 
                        nombre2 = float.Parse(TextBox.Text);
                        result = nombre1 - nombre2;
                        TextBox.Text = result.ToString();
                        minusOperationHappened = true;

                        plusOperationHappened  = false;
                        multiplyOperationHappened = false;
                        divideOperationHappened = false;
                        modulusOperationHappened = false;
                    }
                    else
                    {
                        nombre1 = float.Parse(TextBox.Text);
                        result = nombre1 - nombre2;
                        TextBox.Text = result.ToString();
                    }
                    break;

                case "+":
                    if (plusOperationHappened == false)
                    {
                        nombre2 = float.Parse(TextBox.Text);
                        result = nombre1 + nombre2;
                        TextBox.Text = result.ToString();
                        plusOperationHappened = true;

                        minusOperationHappened = false;
                        multiplyOperationHappened = false;
                        divideOperationHappened = false;
                        modulusOperationHappened = false;
                    }
                    else
                    {
                        nombre1 = float.Parse(TextBox.Text);
                        result = nombre1 + nombre2;
                        TextBox.Text = result.ToString();
                    }
                    break;

                case "*":
                    if (multiplyOperationHappened == false)
                    {
                        nombre2 = float.Parse(TextBox.Text);
                        result = nombre1 * nombre2;
                        TextBox.Text = result.ToString();
                        multiplyOperationHappened = true;

                        minusOperationHappened = false;
                        plusOperationHappened = false;
                        divideOperationHappened = false;
                        modulusOperationHappened = false;
                    }
                    else
                    {
                        nombre1 = float.Parse(TextBox.Text);
                        result = nombre1 * nombre2;
                        TextBox.Text = result.ToString();
                    }
                    break;

                case "/":
                    if (divideOperationHappened == false)
                    {
                        nombre2 = float.Parse(TextBox.Text);
                        result = nombre1 / nombre2;
                        TextBox.Text = result.ToString();
                        divideOperationHappened = true;

                        minusOperationHappened = false;
                        plusOperationHappened = false;
                        multiplyOperationHappened = false;
                        modulusOperationHappened = false;
                    }
                    else
                    {
                        nombre1 = float.Parse(TextBox.Text);
                        result = nombre1 / nombre2;
                        TextBox.Text = result.ToString();
                    }
                    break;

                case "%":
                    if (modulusOperationHappened == false)
                    {
                        nombre2 = float.Parse(TextBox.Text);
                        result = nombre1 % nombre2;
                        TextBox.Text = result.ToString();
                        modulusOperationHappened = true;

                        minusOperationHappened = false;
                        plusOperationHappened = false;
                        multiplyOperationHappened = false;
                        divideOperationHappened = false;
                    }
                    else
                    {
                        nombre1 = float.Parse(TextBox.Text);
                        result = nombre1 % nombre2;
                        TextBox.Text = result.ToString();
                    }
                    break;

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nombre1 = 0.0f;
            nombre2 = 0.0f;
            plusOperationHappened = false;
            minusOperationHappened= false;
            multiplyOperationHappened = false;
            divideOperationHappened = false;
            modulusOperationHappened = false;
            TextBox.Text = "0";
        }
    }
}
