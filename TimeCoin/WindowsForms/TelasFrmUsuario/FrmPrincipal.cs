using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FrmHabilidade hab = new FrmHabilidade();
            hab.ShowDialog();
        }

        private void btnAnuncio_Click(object sender, EventArgs e)
        {
            Service1 sv = new Service1();
            FrmAnuncio anun = new FrmAnuncio();
            anun.ShowDialog();
        }
    }
}
