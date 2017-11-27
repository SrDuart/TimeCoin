using System;
using System.Windows.Forms;
using WindowsForms.localhost;
using WindowsForms.TelasFrmUsuario;
using WindowsForms.TelasFrmAdm;

namespace WindowsForms.TelasFrmPrincipal
{
    public partial class FrmLogar : Form
    {
        public FrmLogar()
        {
            InitializeComponent();
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frmCu = new FrmCadastrarUsuario();
            frmCu.ShowDialog();                       
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Service1 sv = new Service1();
                Usuario usuario = new Usuario();

                if (!(txtUsuario.Text.Contains("@") && txtUsuario.Text.Contains(".com")))
                {
                    usuario.userName = txtUsuario.Text;
                }
                else
                {
                    usuario.email = txtUsuario.Text;
                }

                if (txtUsuario.Text == "Admin" && txtSenha.Text == "admin")
                {
                    FrmAdmPrincipal p = new FrmAdmPrincipal();
                    p.ShowDialog();
                }

                usuario.senha = txtSenha.Text;

                sv.UsuarioVerificaLogin(usuario);

                this.Hide();
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
