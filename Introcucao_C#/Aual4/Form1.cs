using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aual4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gamer_Click(object sender, EventArgs e)
        {
            gamer.Font = new Font("Comic Sans MS",16,FontStyle.Bold); // Font é uma classe e tem um construtor
            gamer.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = " ";
            if (checkBox1.Checked)
                label3.Text += checkBox1.Text + " - ";
            if (checkBox2.Checked)
                label3.Text += checkBox2.Text + " - ";
            if (checkBox3.Checked)
                label3.Text = label3.Text + checkBox3.Text + " - ";
            if (checkBox4.Checked)
                label3.Text = label3.Text + checkBox4.Text + " ";
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
    }
}
