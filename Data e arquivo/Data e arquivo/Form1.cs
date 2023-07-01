using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Data_e_arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Thread é para fazer ações simultaneas 
            Thread thread = new Thread(new ThreadStart(splashScreen)); //esse splashScreen não é o form3, mas uma função 
            thread.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            thread.Abort();
        }

        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void marcarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void marccarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreen f3 = new SplashScreen();
            f3.MdiParent = this;
            f3.Show();
        }

        private void splashToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
