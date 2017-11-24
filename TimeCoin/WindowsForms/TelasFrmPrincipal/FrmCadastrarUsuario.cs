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
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
            Service1 sv = new Service1();
            TipoUsuario[] list = new TipoUsuario[sv.TipoUsuarioSelect().Length];
            list = sv.TipoUsuarioSelect();
            for (int i = 0; i < list.Length; i++)
            {
                comboBox1.Items.Add(list[i].descricao);
            }
        }

        public void CadastrarUsuario()
        {
            Service1 sv = new Service1();
            Usuario usuario = new Usuario();

            try
            {
                #region atribuição de valores

                usuario.tipoUsuario = new TipoUsuario();
                usuario.situacao = new Situacao();

                usuario.tipoUsuario.id = Convert.ToInt32(1);
                usuario.situacao.id = Convert.ToInt32(1);

                usuario.nome = txtNome.Text;
                usuario.userName = txtUserName.Text;
                usuario.cpf_cnpj = txtCpf_Cnpj.Text;
                usuario.telefoneFixo = txtTelFixo.Text;
                usuario.telefoneCelular = txtTelCel.Text;
                usuario.uf = txtUf.Text;
                usuario.cidade = txtCidade.Text;
                usuario.bairro = txtBairro.Text;
                usuario.email = txtEmail.Text;
                usuario.senha = txtSenha.Text;
                usuario.descricao = richTxtBoxDescricao.Text;
                #endregion

                sv.UsuarioInsert(usuario);
                MessageBox.Show("Usuario cadastrado com sucesso");
            }
            catch(Exception ex) {
               throw ex;
            }
            
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }
    }
}
