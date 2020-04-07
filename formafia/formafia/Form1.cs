using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formafia
{
    public partial class Form1 : Form
    {
        int Xz = 1;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (Xz <= 16 && textBox1.Text != "")
            {
                string number = Xz.ToString() + " - " + textBox1.Text;
                listBox1.Items.Add(number);
                Xz++;
                textBox1.Clear();
            }
            else
                MessageBox.Show("Превышен лимит участников(max 16 игроков) или вы не указали свой nick-name");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            Xz = 1;
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            comboBox1.Text = " ";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = listBox1.SelectedItem.ToString().Remove(0, 3);
            }

            if (radioButton2.Checked)
            {
                label2.Text = listBox1.SelectedItem.ToString().Remove(0, 3);
            }

            if (radioButton3.Checked)
            {
                label3.Text = listBox1.SelectedItem.ToString().Remove(0, 3);
            }

            if (radioButton4.Checked)
            {
                label4.Text = listBox1.SelectedItem.ToString().Remove(0, 3);
            }

            if (radioButton5.Checked)
            {
                label5.Text = listBox1.SelectedItem.ToString().Remove(0, 3);
            }

            if (radioButton6.Checked)
            {
                label6.Text = listBox1.SelectedItem.ToString().Remove(0, 3);
            }

            if (radioButton7.Checked)
            {

                comboBox1.Items.Add(listBox1.SelectedItem.ToString().Remove(0, 3));
            }

        }
    }
}
