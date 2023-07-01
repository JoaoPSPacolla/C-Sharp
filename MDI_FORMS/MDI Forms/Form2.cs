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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calc = 0;
            try
            {
                if (comboBox1.SelectedIndex ==0)
                {
                    calc = 5.50 * double.Parse(textBox1.Text);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    calc = 10.80 * double.Parse(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Selecione um frasco", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
