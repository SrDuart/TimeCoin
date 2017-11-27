using System;
using System.ComponentModel;
using System.Windows.Forms;
using WcfService.localhost;

namespace WindowsForms.TelasFrmUsuario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void contextMenuStripPrincipal_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuHabilidade_Click(object sender, EventArgs e)
        {
                     
        }

        private void Menu_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void btnHabilidade_Click(object sender, EventArgs e)
        {
            Service1 sv = new Service1();
            this.Hide();
            FrmHabilidade habilidade = new FrmHabilidade();
            habilidade.ShowDialog();
            this.Close();
        }

        private void btnAnuncio_Click(object sender, EventArgs e)
        {
            Service1 sv = new Service1();
            this.Hide();
            FrmAnuncio anuncio = new FrmAnuncio();
            anuncio.ShowDialog();
            this.Close();
        }
    }
}
