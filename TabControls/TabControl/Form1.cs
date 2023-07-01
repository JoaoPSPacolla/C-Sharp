using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 é enter na tabela ascii
            {
                if (textBox1.Text != string.Empty)
                    maskedTextBox1.Focus();          
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
                textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 1)
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 2)
                textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            else
                MessageBox.Show("Seleciona um cadidato");
            listBox3.ClearSelected(); //desmarca o candidato selecionado
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                try 
                {
                    DateTime dateTime = DateTime.Parse(maskedTextBox1.Text); /* ou */
                    // Covert.ToDateTime(maskedTextBox1.Text)
                    listBox1.Items.Add(textBox1.Text);
                    listBox2.Items.Add(maskedTextBox1.Text);
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                }
                catch
                {
                    MessageBox.Show("Digite uma data válida","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedTextBox1.Focus(); //nao sei o que faz 
                }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //Esse código tá certo mas é meio gambiarra 
            /*if (listBox2.SelectedIndex == listBox1.SelectedIndex)
                if ((this.listBox1.SelectedItem != null)||(this.listBox2.SelectedItem != null)){
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);
                this.listBox2.Items.Remove(this.listBox2.SelectedItem);         
            }*/ 

            try
            {
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um evento");
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Selecione um evento");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }
    }
}
