using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_e_arquivo
{
    public partial class Form2 : Form
    {
        int op = 0;
        string caminho = Directory.GetCurrentDirectory();

        private void resetaTabela()
        {
            foreach (Label controle in tableLayoutPanel1.Controls)
            {
                controle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();

            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamReader texto; // o streamreader serve para manipular arquivo txt
            string linha;

            if (System.IO.File.Exists(caminho + "\\" + nome_arq + ".txt")) 
                texto = new StreamReader(caminho + "\\" + nome_arq + ".txt");
            else
                texto = new StreamReader(caminho + "\\default.txt");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            op = 3;
            resetaTabela();
            label3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

            label3.BackColor = Color.LightGreen;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            op = 5;
            resetaTabela();
            label5.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            op = 7;
            resetaTabela();
            label7.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label6.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            op = 9;
            resetaTabela();
            label9.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label8.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            op = 11;
            resetaTabela();
            label10.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            label11.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op == 3)
            {
                label3.Text = textBox2.Text;
            }
            else if (op == 5)
            {
                label5.Text = textBox2.Text;
            }
            else if (op == 7)
            {
                label7.Text = textBox2.Text;
            }
            else if (op == 9)
            {
                label9.Text = textBox2.Text;
            }
            else if (op == 11)
            {
                label11.Text = textBox2.Text;
            }
            else
                MessageBox.Show("Escolha um horário");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op == 3)
            {
                label3.Text = "Disponível";
            }
            else if (op == 5)
            {
                label5.Text = "Disponível";
            }
            else if (op == 7)
            {
                label7.Text = "Disponível";
            }
            else if (op == 9)
            {
                label9.Text = "Disponível";
            }
            else if (op == 11)
            {
                label11.Text = "Disponível";
            }
            else
                MessageBox.Show("Escolha um horário");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamWriter arquivo;

            if (System.IO.File.Exists(caminho+"\\" + nome_arq + ".txt"));
                File.Delete(caminho+"\\" + nome_arq + ".txt");
            arquivo = new StreamWriter(caminho+"\\" + nome_arq + ".txt");

            foreach (Label controle in tableLayoutPanel1.Controls)
            {
                arquivo.WriteLine(controle.Text);
            }
            arquivo.Close();

            MessageBox.Show("Salvo com sucesso", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
