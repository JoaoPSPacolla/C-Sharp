using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer_MDI_paraProva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcularCombustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 form2 = new Form2();
                form2.MdiParent = this; // o formulario vai ficar dentro do mdi container/pai
                form2.Show();
            }
        }

        private void calcularÓleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 form3 = new Form3();
                form3.MdiParent = this;
                form3.Show();
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ajuda = new AboutBox1();
            ajuda.Show();
        }
    }
}
