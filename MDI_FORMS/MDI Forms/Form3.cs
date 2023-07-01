using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float calc;
            try
            {
                if (radioButton1.Checked)
                {
                    calc = (float.Parse(textBox1.Text) * float.Parse(textBox3.Text));
                    label5.Text = calc.ToString("0.00");
                }
                else if (radioButton2.Checked)
                {
                    calc = (float.Parse(textBox2.Text) * float.Parse(textBox3.Text));
                    label5.Text = calc.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Selecione um combustível", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }//TRY
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Operação Finalizada");
            }
        }
    }
}
