using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refazendomaisumavezaprova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AboutBox1>().Count() == 0)
            {
                AboutBox1 ajuda = new AboutBox1();
                ajuda.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void festasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 filho2 = new Form2();
            filho2.Show();
        }
    }
}
