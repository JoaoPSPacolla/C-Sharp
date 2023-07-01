using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1_Exemplo1
{
    public partial class Form1 : Form
    {
        public Form1() //Construtor
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lindao.Text = "Hello World";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Text = "ÓÓÓÓÓÓÓ";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            lindao.Text = "Bom dia, Puta";
        }
    }
}
