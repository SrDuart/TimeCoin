using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmUsuario
{
    public partial class FrmConsultarAnuncio : Form
    {
        int[] idTipoAnuncio;

        public FrmConsultarAnuncio()
        {
            InitializeComponent();

            Service1 sv = new Service1();
            TipoAnuncio[] listTipoAnuncio = new TipoAnuncio[sv.TipoAnuncioSelect().Length];
            listTipoAnuncio = sv.TipoAnuncioSelect();
            listTipoAnuncio = new TipoAnuncio[sv.TipoAnuncioSelect().Length];

            for (int i = 0; i < listTipoAnuncio.Length; i++)
            {
                comboBoxTipoAnuncio.Items.Add(listTipoAnuncio[i].descricao);
                idTipoAnuncio[i] = listTipoAnuncio[i].id;
            }
        }

        public void ConsultarAnuncio()
        {
            Service1 sv = new Service1();
            Anuncio anuncio = new Anuncio();
            TipoAnuncio tipoAnuncio = new TipoAnuncio();

             try
             {
                #region atribuição de valores

                anuncio.tipoAnuncio = new TipoAnuncio();
                anuncio.usuario = new Usuario();
                anuncio.servico = new Servico();
                anuncio.situacao = new Situacao();

                anuncio.tipoAnuncio.id = Convert.ToInt32(idTipoAnuncio[comboBoxTipoAnuncio.SelectedIndex]);
                anuncio.usuario.id = Convert.ToInt32(1);
                anuncio.servico.id = Convert.ToInt32(1);
                anuncio.situacao.id = Convert.ToInt32(1);

                tipoAnuncio.descricao = listBoxConsulta.Text;
                tipoAnuncio.descricao = comboBoxLocalidade.Text;
                tipoAnuncio.descricao = comboBoxTipoAnunciante.Text;
                #endregion                
                    
                sv.TipoAnuncioInsert(tipoAnuncio);

                MessageBox.Show("");

                this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        private void FrmConsultarAnuncio_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarAnuncio();
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
        }
    }
}
