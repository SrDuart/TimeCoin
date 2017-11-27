using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmUsuario
{
    public partial class FrmAnuncio : Form
    {
        public FrmAnuncio()
        {
            InitializeComponent();
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
                anuncio.data = Convert.ToDateTime(txtData.Text);
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
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
        }
    }
}
