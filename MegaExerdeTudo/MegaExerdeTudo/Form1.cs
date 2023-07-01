using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaExerdeTudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabcontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 filho2 = new Form2();
            filho2.MdiParent = this;
            filho2.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ajuda = new AboutBox1();
            ajuda.Show();   
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 filho4 = new Form4();
            filho4.MdiParent = this;
            filho4.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 filho3 = new Form3();
            filho3.MdiParent = this;
            filho3.Show();
        }

        private void abrirFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 filho5 = new Form5();
            filho5.MdiParent = this;
            filho5.Show();
        }

        private void comboEListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splashScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 filho6 = new Form6();
            filho6.Show();
        }
    }
}
