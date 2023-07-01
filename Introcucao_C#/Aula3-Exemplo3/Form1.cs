using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3_Exemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if(textBox1.Text == "COTIL")
            {
                Bolsonaro.Text = "Acertou!";
            }
            else
            {
                Bolsonaro.Text = "Errou";
            }*/

            switch (textBox1.Text)
            {
                case "COTIL":
                    Bolsonaro.Text = "Acertou: Cotil";
                    break;
                case "Unicamp":
                    Bolsonaro.Text = "Acertou: Unicamp";
                    break;
                default:
                    Bolsonaro.Text = "Escreveu" + textBox1.Text;
                    break;
            }


        }

        private void Bolsonaro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
