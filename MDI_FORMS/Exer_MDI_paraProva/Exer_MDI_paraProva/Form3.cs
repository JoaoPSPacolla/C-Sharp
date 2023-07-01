using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer_MDI_paraProva
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            label5.Text = null;
            numericUpDown1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float calc;
            float preco500ml = 2.50f;
            float preco1l = 5f;
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (numericUpDown1.Value > 0)
                    {
                        calc = (float)numericUpDown1.Value * preco500ml;
                        label5.Text = calc.ToString();
                    }
                }
                else if(comboBox1.SelectedIndex == 1) 
                {
                    if (numericUpDown1.Value > 0)
                    {
                        calc = (float)numericUpDown1.Value * preco1l;
                        label5.Text = calc.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um frasco");
                }
            }
            catch (Exception ex) //essa exception é a exceção geral, ou seja, que abrange todas as outras
            {
                MessageBox.Show("O campo Qtde não pode ser igual a 0");
            }
        }
    }
}
