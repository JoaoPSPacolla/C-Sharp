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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Label label = new Label();
                label.Text = "C#";
                tableLayoutPanel1.Controls.Add(label, 0, tableLayoutPanel1.RowCount);
            }
            if (checkBox2.Checked)
            {
                Label label = new Label();
                label.Text = "JavaScript";
                tableLayoutPanel1.Controls.Add(label, 0, tableLayoutPanel1.RowCount);
            }
        }
    }
}
