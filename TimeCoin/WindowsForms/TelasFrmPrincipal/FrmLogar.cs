using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.localhost;

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

                if (txtUsuario.TextLength > 20 )
                {
                    usuario.userName = txtUsuario.Text;
                }
                else
                {
                    usuario.email = txtUsuario.Text;
                }
                usuario.senha = txtSenha.Text;

               // sv.UsuarioVerificaLogin(usuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
