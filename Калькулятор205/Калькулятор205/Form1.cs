using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор205
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double number1;
        double number2;
        double result;
        string sign;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            if (sign== null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text= null;
            button11.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button20.Enabled = true;
            button19.Enabled = true;
            button17.Enabled = true;
            result = 0;
            number1 = 0;
            number2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            if (sign == null)
            { number1 = float.Parse(textBox1.Text); }
            else
            {
                number2 = float.Parse(textBox1.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sign = "/";
            textBox1.Text += "/";
            textBox1.Text = null;
            button11.Enabled= false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;
          

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            sign = "*";
            textBox1.Text = null;
            button11.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            sign = "-";
            textBox1.Text = null;
            button11.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            sign = "+";
            textBox1.Text = null;
            button11.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;
          

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
            switch (sign)
            {
                case "/": result=number1/number2;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    result = number1*number2;
                    textBox1.Text = result.ToString();
                    break;
                case "+":
                    result = number1+number2;
                    textBox1.Text = result.ToString();
                    break;
                case "-":
                    result = number1-number2;
                    textBox1.Text = result.ToString();
                    break;
            }
            

            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
            sign = "√";
            textBox1.Text = null;
            button11.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
            sign = "%";
            textBox1.Text = null;
            button11.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button20.Enabled = false;
            button19.Enabled = false;
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            button17.Enabled = false;

        }
    }
}
