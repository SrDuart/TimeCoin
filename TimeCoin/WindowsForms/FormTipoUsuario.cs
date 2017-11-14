using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms
{
    public partial class FormTipoUsuario : Form
    {

        public List<TipoUsuario> lista = null;

        public FormTipoUsuario()
        {
            InitializeComponent();
        }

        public void Atualizar()
        {
            try
            {
                Service1 serv = new Service1();
                TipoUsuario tipo = new TipoUsuario();
                tipo.descricao = txtDescricao.Text;
                lista = serv.TipoUsuarioSelect(tipo).ToList();

                listView1.Items.Clear();
                foreach (TipoUsuario tipousuario in lista)
                {
                    ListViewItem iv = listView1.Items.Add(tipousuario.id.ToString());
                    iv.SubItems.Add(tipousuario.descricao);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices != null)
            {
                FormTipoUsuarioManter form = new FormTipoUsuarioManter();
                form.operacao = Operacao.CONSULTAR;
                form.tipousuario = lista.ElementAt(listView1.SelectedIndices[0]);
                form.Inicialize();
                form.ShowDialog(this);
                Atualizar();
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormTipoUsuarioManter form = new FormTipoUsuarioManter();
            form.operacao = Operacao.INCLUIR;
            form.Inicialize();
            form.ShowDialog(this);
            Atualizar();
        }
    }
}
