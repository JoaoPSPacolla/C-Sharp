using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exeemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campo Obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();



        }

        private void Pergunta_Click(object sender, EventArgs e)
        {
            DialogResult bolinha = MessageBox.Show("Tem certeza que deseja apertar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (bolinha == DialogResult.Yes)
                MessageBox.Show("Apertou Sim","askaafyuashsagas");
            else
                MessageBox.Show("Apertou Não","ihugbuyrg");
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Miau";
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult bolinha = MessageBox.Show("Tem certeza que deseja sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (bolinha == DialogResult.No)
                e.Cancel = true;
        }
    }
}
