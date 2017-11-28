using System;
using System.Windows.Forms;
using WindowsForms.localhost;
using WindowsForms.TelasFrmUsuario;
using WindowsForms.TelasFrmAdm;
using System.Threading;

namespace WindowsForms.TelasFrmPrincipal
{
    public partial class FrmLogar : Form
    {
        Thread th;
        public FrmLogar()
        {
            InitializeComponent();
        }

        public void FrmEntrar()
        {
            Application.Run(new FrmPrincipal());
        }

        public void FrmAdm()
        {
            Application.Run(new FrmAdmPrincipal());
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
                    th = new Thread(FrmAdm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();
                }

                usuario.senha = txtSenha.Text;

                sv.UsuarioVerificaLogin(usuario);

                th = new Thread(FrmEntrar);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
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
