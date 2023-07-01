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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 filho2 = new Form2();
                filho2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {      
            Form3 filho3 = new Form3();
            filho3.Show();       
        }
    }
}
