using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() > 0)
            {
                MessageBox.Show("O formulário ja está aberto!");
            }
            else
            {
                button1.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
                Form2 form2 = new Form2();
                form2.Show();
            }
            
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void subopcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
                form2.BackColor = Color.Yellow;
                form2.Show(); 
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
