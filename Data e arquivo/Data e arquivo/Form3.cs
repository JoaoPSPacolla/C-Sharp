using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_e_arquivo
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //incremento de 1 em 1 da barra de progresso
            progressBar2.Increment(1);
            //quando a barra estiver completa
            if (progressBar2.Value == 100)
                //desliga o timer
                timer1.Stop();
        }
    }
}
