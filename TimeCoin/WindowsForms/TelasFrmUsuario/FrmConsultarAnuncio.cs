using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmUsuario
{
    public partial class FrmConsultarAnuncio : Form
    {
        public FrmConsultarAnuncio()
        {
            InitializeComponent();
        }

        public void ConsultarAnuncio()
        {
            Service1 sv = new Service1();
            Anuncio anuncio = new Anuncio();
            TipoAnuncio tipoAnuncio = new TipoAnuncio();
            
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
