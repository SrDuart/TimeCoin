using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmUsuario
{
    public partial class FrmAnuncio : Form
    {
        //int[] idUsuario;

        public FrmAnuncio()
        {
            InitializeComponent();

            InitializeComponent();

            /*Service1 sv = new Service1();
            Usuario[] listUsuario = new Usuario[sv.UsuarioSelect().Length];
            listUsuario = sv.UsuarioSelect();
            idUsuario = new int[sv.UsuarioSelect().Length];

            for (int i = 0; i < listUsuario.Length; i++)
            {
                richTxtBoxServico.Select(listUsuario[i].id);
                idUsuario[i] = listUsuario[i].id;
            }*/
        }
        
        public void CadastrarAnuncio()
        {
            Service1 sv = new Service1();
            Anuncio anuncio = new Anuncio();

            try
            {
                anuncio.servico = new Servico();
                anuncio.situacao = new Situacao();
                anuncio.tipoAnuncio = new TipoAnuncio();
                anuncio.usuario = new Usuario();

                #region Atribuição de valores
                anuncio.data = Convert.ToDateTime(maskedTxtBoxData.Text);
                anuncio.usuario.id = Convert.ToInt32(richTxtBoxServico.Text);
                anuncio.descricao = richTxtBoxDescricao.Text;
                anuncio.bairro = txtBairro.Text;
                anuncio.cidade = txtCidade.Text;
                anuncio.preRequisito = txtPreRequisito.Text;
                anuncio.uf = txtUf.Text;
                #endregion

                sv.AnuncioInsert(anuncio);

                MessageBox.Show("Anúncio cadastrado com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAnuncio();
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();

            FrmAnuncio anuncio = new FrmAnuncio();
            this.Close();
        }

        private void lblUf_Click(object sender, EventArgs e)
        {

        }
    }
}
