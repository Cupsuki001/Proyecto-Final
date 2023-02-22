namespace Proyecto
{
    public partial class Form1 : Form
    {
        Form2 balance = new Form2();
        Form3 nuevo = new Form3();
        Form4 resultado = new Form4();
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }



        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultado.MdiParent = this;
            resultado.Show();
        }

        private void nuevoBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void mostrarBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balance.MdiParent = this;
            balance.Show();
        }
    }
}