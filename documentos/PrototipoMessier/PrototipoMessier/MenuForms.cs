namespace PrototipoMessier
{
    public partial class Form1 : Form
    {
        JogosForms frmJogos;
        PacoteForms frmPacotes;
        HelpForms frmHelp;
        RelEscolaForms frmRelEscola;

        public Form1()
        {
            InitializeComponent();
            frmJogos = new JogosForms();
            frmPacotes = new PacoteForms();
            frmHelp = new HelpForms();
            frmRelEscola = new RelEscolaForms();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacotes.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp.ShowDialog();
        }

        private void relatorioEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelEscola.ShowDialog();
        }
        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
