using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoUsuario form = new FormTipoUsuario();
            form.ShowDialog(this);
        }

        private void cadastroDeHabilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHabilidade form = new FormHabilidade();
            form.ShowDialog(this);
        }
    }
}
