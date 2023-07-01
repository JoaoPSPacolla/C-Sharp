using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFoda
{
    public partial class Form1 : Form
    {
        int op = 0;
        double result = 0, n1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void botaoPonto_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(","))) // se nao tiver virgula, coloca
                textBox1.Text = textBox1.Text + ",";
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            if (op == 1)
                result = n1 + double.Parse(textBox1.Text);
            else if (op == 2)
                result = n1 + double.Parse(textBox1.Text);
            else if (op == 3)
                result = n1 + double.Parse(textBox1.Text);
            else if (op == 4)
                result = n1 + double.Parse(textBox1.Text);
            if (String.IsNullOrEmpty(textBox1.Text)) ;
        }

        private void botaoDiv_Click(object sender, EventArgs e)
        {
            op = 4;
            textBox1.Text = textBox1.Text + "/";
            if (String.IsNullOrEmpty(textBox1.Text)) ;
        }

        private void botaoMenios_Click(object sender, EventArgs e)
        {
            op = 2;
            textBox1.Text = textBox1.Text + "-";
            if (String.IsNullOrEmpty(textBox1.Text)) ;
        }

        private void botaoSeta_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
;        }

        private void botaoMult_Click(object sender, EventArgs e)
        {
            op = 3;
            textBox1.Text = textBox1.Text + "*";
            if (String.IsNullOrEmpty(textBox1.Text)) ;
        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            op = 1;
            textBox1.Text = textBox1.Text + "+";
            if (String.IsNullOrEmpty(textBox1.Text)) ;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botao2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
