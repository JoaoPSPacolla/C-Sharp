namespace RefazendoProva
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

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ajuda = new AboutBox1();
            ajuda.Show();
        }

        private void festasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 filho2 = new Form2();
            filho2.MdiParent = this;
            filho2.Show();
        }
    }
}