using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_novaAba_Click(object sender, EventArgs e)
        {
            if(tb_novaAba.Text != "")
            {
              TabPage pagina = new TabPage();
              pagina.Text = tb_novaAba.Text;
              pagina.Name = tb_novaAba.Text;
              pagina.TabIndex = tabControl1.TabPages.Count;
              tabControl1.TabPages.Add(pagina);
              tb_novaAba.Clear();
            }
            else
            {
                MessageBox.Show("Digite o nome da página que quer adicionar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_removeAba_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void btn_posicionaTab_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value <= tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
            }
            else
            {
                MessageBox.Show("Selecione um numero de aba existente", "Essa aba não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
