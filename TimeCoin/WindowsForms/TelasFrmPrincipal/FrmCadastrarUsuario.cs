using System;  
using System.Windows.Forms;
using WindowsForms.localhost;
using WindowsForms.TelasFrmUsuario;

namespace WindowsForms.TelasFrmPrincipal
{
    public partial class FrmCadastrarUsuario : Form

    {
        TipoUsuario[] listTipoUsuario;
        Habilidade[] listHabilidade;
        public FrmCadastrarUsuario()
        {
            InitializeComponent();

            Service1 sv = new Service1();
            listTipoUsuario = sv.TipoUsuarioSelect();

            foreach (TipoUsuario t in listTipoUsuario)
            {
                comboBoxTipoUsuario.Items.Add(t.descricao);
            }

            Habilidade habilidade = new Habilidade();
            listHabilidade = sv.HabilidadeSelect(habilidade);

            foreach (Habilidade h in listHabilidade)
            {
                listBoxHabilidadesDisponiveis.Items.Add(h.nome);
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

                usuario.tipoUsuario.id = Convert.ToInt32(listTipoUsuario[comboBoxTipoUsuario.SelectedIndex].id);
                usuario.situacao.id = Convert.ToInt32(1);

                usuario.nome = txtNome.Text;
                usuario.userName = txtUserName.Text;
                usuario.cpf_cnpj = maskedTxtBoxCpf_Cnpj.Text;
                usuario.telefoneFixo = maskedTxtBoxTelFixo.Text;
                usuario.telefoneCelular = maskedTxtBoxTelCel.Text;
                usuario.uf = txtUf.Text;
                usuario.cidade = txtCidade.Text;
                usuario.bairro = txtBairro.Text;
                usuario.email = txtEmail.Text;
                usuario.senha = txtSenha.Text;
                usuario.descricao = richTxtBoxDescricao.Text;
                #endregion

                sv.UsuarioInsert(usuario);

                usuario = sv.SelecionaUsuario(usuario);

                UsuarioHabilidade usuarioHabilidade = new UsuarioHabilidade();



                MessageBox.Show("Usuário cadastrado com sucesso");

                this.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {            
            CadastrarUsuario();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBoxHabilidadesDisponiveis.SelectedIndex;
            listBoxHabilidadeSelecionadas.Items.Add(listHabilidade[index].nome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxHabilidadeSelecionadas.Items.Remove(listBoxHabilidadeSelecionadas.SelectedItem);
        }
    }
}
