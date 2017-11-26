﻿using System;  
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
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
        }

        private void txtCpf_Cnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelCel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelFixo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
