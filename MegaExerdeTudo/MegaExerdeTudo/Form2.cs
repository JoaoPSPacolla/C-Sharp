using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaExerdeTudo
{
    public partial class Form2 : Form
    {
        int num1 = 0;
        int num2 = 0;
        float num3 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {           
                if (e.KeyChar == 13)
                {
                    maskedTextBox1.Focus();
                }          
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Convert.ToDateTime(maskedTextBox1.Text);
                    listBox1.Items.Add (textBox1.Text);
                    listBox2.Items.Add (maskedTextBox1.Text);
                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
                catch
                {
                    MessageBox.Show("Data Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {
                num1 += 1;
                string numString = num1.ToString();
                textBox2.Text = numString;
            }
            if (listBox3.SelectedIndex == 1) 
            {
                num2 += 1;
                string numString = num2.ToString();
                textBox3.Text = numString;
            }
            if (listBox3.SelectedIndex == 2)
            {
                num3 += 1;
                string numString = num3.ToString();
                textBox4.Text = numString;
            }
            else
            {
                MessageBox.Show("Selecione um candidato");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1 > 0)
            {
                num1 -= 1;
                string numString = num1.ToString();
                textBox2.Text = numString;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num2 > 0)
            {
                num2 -= 1;
                string numString = num2.ToString();
                textBox3.Text = numString;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num3 > 0)
            {
                num3 -= 1;
                string numString = num3.ToString();
                textBox4.Text = numString;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TabPage novaAba = new TabPage();
            novaAba.Text = "Nova aba";
            tabControl1.TabPages.Add(novaAba);
        }
    }
}
