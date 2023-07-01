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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calcula_Click(object sender, EventArgs e)
        {
            float calc;
            try
            {
                if (btn_gasolina.Checked)
                {
                    calc = (float.Parse(textBox2.Text) * float.Parse(textBox3.Text));
                    label5.Text = calc.ToString("0.00");
                }
                else if (btn_etanol.Checked)
                {
                    calc = (float.Parse(textBox1.Text) * float.Parse(textBox3.Text));
                    label5.Text = calc.ToString("0.00"); //o 0.00 é o modo como vai aparecer no label
                }
                else
                {
                    MessageBox.Show("Selecione um combustível", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Dodos incorretos");
            }
        }

        private void limpa_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            btn_etanol.Checked = false;
            btn_gasolina.Checked = false;  
        }
    }
}
