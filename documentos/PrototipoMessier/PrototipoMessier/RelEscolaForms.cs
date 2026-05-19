using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class RelEscolaForms : Form
    {
        public RelEscolaForms()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string relatorio = "";

            relatorio += "=============================================\r\n";
            relatorio += "      RELATÓRIO DE ESCOLAS - MESSIER\r\n";
            relatorio += "=============================================\r\n\n";

            relatorio += "Período: Maio/2026\r\n";
            relatorio += "Data de geração: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\r\n\n";

            relatorio += "ESCOLA                     PACOTE             USO\r\n";
            relatorio += "--------------------------------------------------------\r\n";

            relatorio += "Escola Horizonte          Fundamental I      84%\r\n";
            relatorio += "Instituto Saber           Fundamental II     62%\r\n";
            relatorio += "Colégio Nova Geração      Ensino Médio       78%\r\n";
            relatorio += "Escola Criativa Kids      Fundamental I      91%\r\n";
            relatorio += "Centro Educacional Alpha  Ensino Médio       55%\r\n";

            relatorio += "\r\n=============================================\r\n";
            relatorio += "Resumo:\r\n";
            relatorio += "• Escolas cadastradas: 5\r\n";
            relatorio += "• Pacote mais utilizado: Fundamental I\r\n";
            relatorio += "• Média de uso dos jogos: 74%\r\n";
            relatorio += "=============================================";

            txtRel.Text = relatorio;
        }
    }
}
