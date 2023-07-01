using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefazendoProva
{
    public partial class Form2 : Form
    {
        StreamWriter arquivoGravação;
        public Form2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.ResetText();
            listBox1.Items.Clear();
            label2.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma opção de festa: Infantil ou Adulto", "Atenção", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }

            try
            {
                string opSelecionada = (listBox1.SelectedItem.ToString());
                string[] partes = opSelecionada.Split('-');
                string numOp = partes[1].Trim();
                if ((checkBox1.Checked == true) || (checkBox2.Checked == true))
                {
                    float valorSoma = 80.00f;
                    float resultado = float.Parse(numOp) + valorSoma;
                    label2.Text = resultado.ToString("0000.00");
                }
                else
                {
                    label2.Text = numOp;
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Selecione uma decoração que aparece no quadrado branco", "Atenção"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            /*
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma festa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if((checkBox1.Checked = false)||(checkBox2.Checked = false))
            {
                MessageBox.Show("Selecione uma")
            }
            */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Safari - 2000.00");
                listBox1.Items.Add("LadyBug - 3000.00");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("Disco - 1500.00");
                listBox1.Items.Add("40 anos - 3000.00");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo;
                arquivo = new StreamWriter("C:\\" + arquivoGravação + ".txt");
                arquivo.WriteLine(textBox1.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo Gravado com Sucesso!");
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
