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

namespace mafia
{
    public partial class Form1 : Form
    {
        int Chet = 1;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Chet <= 16)
            {
                string number = Chet.ToString() + " - " + textBox1.Text;
                listBox1.Items.Add(number);
                Chet++;
                TextBox1.Clear();
            }
            else
                MessageBox.Show("Превышен лимит участников");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                label1.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton2.Checked)
            {
                label2.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton3.Checked)
            {
                label3.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton4.Checked)
            {
                label4.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton5.Checked)
            {
                label5.Text = listBox1.SelectedItem.ToString();
            }
            if (radioButton6.Checked)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
            }
        }
            private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
