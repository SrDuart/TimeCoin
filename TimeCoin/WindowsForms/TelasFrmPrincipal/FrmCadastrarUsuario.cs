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
using WindowsForms.TelasFrmUsuario;

namespace WindowsForms.TelasFrmPrincipal
{
    public partial class FrmCadastrarUsuario : Form
    {
        int[] idTipoUsuario;

        public FrmCadastrarUsuario()
        {
            InitializeComponent();

            Service1 sv = new Service1();
            TipoUsuario[] listTipoUsuario = new TipoUsuario[sv.TipoUsuarioSelect().Length];
            listTipoUsuario = sv.TipoUsuarioSelect();
            idTipoUsuario = new int[sv.TipoUsuarioSelect().Length];

            for (int i = 0; i < listTipoUsuario.Length; i++)
            {
                comboBox1.Items.Add(listTipoUsuario[i].descricao);
                idTipoUsuario[i] = listTipoUsuario[i].id;
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

                usuario.tipoUsuario.id = Convert.ToInt32(idTipoUsuario[comboBox1.SelectedIndex]);
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

                MessageBox.Show("Usuário cadastrado com sucesso");

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
        }
    }
}
