using System;
using System.Windows.Forms;
using WindowsForms.TelasFrmPrincipal;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmAdm
{
    public partial class FrmAdmPrincipal : Form
    {
        Service1 sv = new Service1();

        public FrmAdmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnuncio_Click(object sender, EventArgs e)
        {            
            this.Hide();

            FrmAdmAnuncio admAnuncio = new FrmAdmAnuncio();
            admAnuncio.ShowDialog();

            this.Close();
        }

        private void btnHabilidade_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdmHabilidade admHabilidade = new FrmAdmHabilidade();
            admHabilidade.ShowDialog();
            this.Close();
            FrmLogar logar = new FrmLogar();
            logar.ShowDialog();
        }

        private void FrmAdmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
