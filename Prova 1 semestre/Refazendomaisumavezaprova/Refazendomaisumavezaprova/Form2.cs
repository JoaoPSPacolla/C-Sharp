using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Refazendomaisumavezaprova
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox1.Items.Add("Safari - 2000");
                listBox1.Items.Add("Barney - 5000");
            }
            if(comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Discoteca - 1500");
                listBox1.Items.Add("40 anos - 3000");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToString();
            label5.Text = monthCalendar1.SelectionRange.Start.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            //listBox1.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione uma opção de festa", "Clique em uma das opções do retangulo com uma seta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {               
                    if (listBox1.SelectedIndex < 0)
                    {
                        MessageBox.Show("Selecione um tipo de festa", "Clique em uma das opções do quadrado branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (listBox1.SelectedIndex >= 0)
                    {
                        string escolhalist = listBox1.SelectedItem.ToString();
                        string[] separar = escolhalist.Split('-');
                        string num = separar[1].Trim();

                        if ((checkBox1.Checked == true) || (checkBox2.Checked == true))
                        {
                            float numto = float.Parse(num);
                            numto += 80;
                            //  float valor = 80.00f;    
                            label4.Text = numto.ToString(".00");
                        }
                        else
                        {
                            label4.Text = num;
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter arquivo = new StreamWriter("nome_arquivo.txt", true))
                {
                    arquivo.WriteLine(textBox1.Text = monthCalendar1.SelectionRange.Start.ToString());
                    arquivo.WriteLine(label4.Text);
                   // arquivo.Close();           
                }
                MessageBox.Show("Arquivo gravado com sucesso", "", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Não foi possível gravar","", MessageBoxButtons.OK);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                int soma = int.Parse(maskedTextBox1.Text);
                int total = soma + 40;
                label6.Text = total.ToString();
            }
        }
    }
}
