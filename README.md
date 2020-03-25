# Labs205
Labs205
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coronovirus
{
    public partial class Form1 : Form
    {
        double bufer;
        double bufer1;
        bool plus = false;
        bool minuse = false;
        bool del = false;
        bool umnoj = false;
        double pasent;
        string TexBox;
        bool Zap = true;
        bool noll = true;
        double bufer3;
        bool TTT = true; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "5";
                noll = false;
            }
            else
                textBox1.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                
                textBox1.Text = "0";
                
            }
            else
                textBox1.Text += "0";



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "1";
                noll = false;
            }
            else
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "2";
                noll = false;
            }
            else
                textBox1.Text += "2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "3";
                noll = false;
            }
            else
                textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "4";
                noll = false;
            }
            else
                textBox1.Text += "4";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "6";
                noll = false;
            }
            else
                textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "7";
                noll = false;
            }
            else
                textBox1.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "8";
                noll = false;
            }
            else
                textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (noll == true)
            {
                textBox1.Text = null;
                textBox1.Text += "9";
                noll = false;
            }
            else
                textBox1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.Text = "0";
            Zap = true;
            noll = true;
             plus = false;
             minuse = false;
             del = false;
             umnoj = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bufer = double.Parse(textBox1.Text);
            textBox1.Text = null;
            plus = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (plus == true)
           {
                
                bufer1 = double.Parse(textBox1.Text);
                bufer1 = bufer1 + bufer;
                textBox1.Text = bufer1.ToString();
           }

            if (minuse == true)
            {
                if (TTT == true)
                bufer1 = double.Parse(textBox1.Text);
                bufer3 = bufer1;
                bufer = bufer - bufer3;
                textBox1.Text = bufer.ToString();
            }

            if (umnoj == true)
            {
                bufer1 = double.Parse(textBox1.Text);
                bufer1 = bufer1 * bufer;
                textBox1.Text = bufer1.ToString();
            }

            if (del == true)
            {
                bufer1 = double.Parse(textBox1.Text);
                bufer3 = bufer1;
                bufer = bufer / bufer3;
                textBox1.Text = bufer.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bufer = double.Parse(textBox1.Text);
            textBox1.Text = null;
            minuse = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bufer = double.Parse(textBox1.Text);
            textBox1.Text = null;
            umnoj = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bufer = double.Parse(textBox1.Text);
            textBox1.Text = null;
            del = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Zap == true)
            {
                textBox1.Text += ",";
                Zap = false;
            }
            
            
 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pasent = double.Parse(textBox1.Text) / 100;
            textBox1.Text = pasent.ToString();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Brown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Black;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Brown;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Black;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Brown;
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = System.Drawing.Color.Brown;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = System.Drawing.Color.Brown;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackColor = System.Drawing.Color.Brown;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = System.Drawing.Color.Brown;
        }

        private void button10_MouseMove(object sender, MouseEventArgs e)
        {
            button10.BackColor = System.Drawing.Color.Brown;
        }

        private void button18_MouseMove(object sender, MouseEventArgs e)
        {
            button18.BackColor = System.Drawing.Color.Brown;
        }

        private void button17_MouseMove(object sender, MouseEventArgs e)
        {
            button17.BackColor = System.Drawing.Color.Brown;
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {
            button16.BackColor = System.Drawing.Color.Brown;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.BackColor = System.Drawing.Color.Brown;
        }

        private void button15_MouseMove(object sender, MouseEventArgs e)
        {
            button15.BackColor = System.Drawing.Color.Brown;
        }

        private void button14_MouseMove(object sender, MouseEventArgs e)
        {
            button14.BackColor = System.Drawing.Color.Brown;
        }

        private void button13_MouseMove(object sender, MouseEventArgs e)
        {
            button13.BackColor = System.Drawing.Color.Brown;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Brown;
        }

        private void button11_MouseMove(object sender, MouseEventArgs e)
        {
            button11.BackColor = System.Drawing.Color.Brown;
        }

        private void button12_MouseMove(object sender, MouseEventArgs e)
        {
            button12.BackColor = System.Drawing.Color.Brown;
        }

        private void button19_MouseMove(object sender, MouseEventArgs e)
        {
            button19.BackColor = System.Drawing.Color.Brown;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.Black;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = System.Drawing.Color.Black;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = System.Drawing.Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.Black;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = System.Drawing.Color.Black;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = System.Drawing.Color.Black;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = System.Drawing.Color.Black;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = System.Drawing.Color.Black;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = System.Drawing.Color.Black;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = System.Drawing.Color.Black;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = System.Drawing.Color.Black;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = System.Drawing.Color.Black;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = System.Drawing.Color.Black;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = System.Drawing.Color.Black;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = System.Drawing.Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Black;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TexBox = textBox1.Text;
            TexBox = TexBox.Insert(0, "-");
            textBox1.Text = TexBox;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
