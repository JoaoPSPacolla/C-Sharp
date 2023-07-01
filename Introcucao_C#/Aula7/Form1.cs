using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte achou = 0;

            foreach (string item in listBox1.Items)
            {
                if (item == comboBox1.Text)
                {
                    achou = 1;
                    break;
                }
            }
            if (achou == 0)
                listBox1.Items.Add(comboBox1.Text);

            for (int i = 0; i <= 100; i++)  //só vai até 100
                progressBar1.Value = i;

            // comboBox é vetor
            //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bdclick(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }
    }
}
