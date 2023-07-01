using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCyberpunk
{
    public partial class Form1 : Form
    {
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Produto
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //Quantidade
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //Preço
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //botão mais
        {
         
            Double a = Double.Parse(textBox2.Text);
            Double b = Double.Parse(textBox3.Text);
            Double c = a * b;

            listBox1.Items.Add(textBox1.Text + " - " + (c));

            total += c; //acumula
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            listBox1.Items.Clear();
            label5.Text = "0";
            total = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String total2 = Convert.ToString(total);
            label5.Text = total2;
        }

        private void label5_Click(object sender, EventArgs e) // mostra total
        {

        }
    }
}
