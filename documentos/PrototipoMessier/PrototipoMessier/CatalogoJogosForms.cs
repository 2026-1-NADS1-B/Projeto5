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
    public partial class CatalogoJogosForms : Form
    {
        public CatalogoJogosForms()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo Soma Ninja...");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo Detetive das Vogais...");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo Missão Animal...");
        }
    }
}
