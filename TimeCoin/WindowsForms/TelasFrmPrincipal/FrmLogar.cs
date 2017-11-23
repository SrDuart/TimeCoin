using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.TelasFrmPrincipal
{
    public partial class FrmLogar : Form
    {
        public FrmLogar()
        {
            InitializeComponent();
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frmCu = new FrmCadastrarUsuario();
            frmCu.ShowDialog();
        }
    }
}
