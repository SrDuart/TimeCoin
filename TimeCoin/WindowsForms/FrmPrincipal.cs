using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoUsuario form = new FrmTipoUsuario();
            form.ShowDialog(this);
        }

        private void cadastroDeHabilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHabilidade form = new FrmHabilidade();
            form.ShowDialog(this);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
