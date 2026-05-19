using System;
using System.Windows.Forms;

namespace PrototipoMessier
{
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuário.Text == "admin" && txtSenha.Text == "123")
            {
                Form1 menuAdmin = new Form1();
                menuAdmin.Show();
                this.Hide();
            }
            else if (txtUsuário.Text == "escolaCriativa@gmail.com" && txtSenha.Text == "123456")
            {
                CatalogoJogosForms catalogo = new CatalogoJogosForms();
                catalogo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
    }
}
