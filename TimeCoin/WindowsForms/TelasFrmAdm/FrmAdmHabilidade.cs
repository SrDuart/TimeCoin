using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmAdm
{
    public partial class FrmAdmHabilidade : Form
    {
        Habilidade[] listaHabilidade;
        
        public FrmAdmHabilidade()
        {
            InitializeComponent();
            btnConfirmar.Enabled = false;
        }

        public void InserirHabilidade()
        {
            try
            {               
               
                 Service1 sv = new Service1();
                 Habilidade habilidade = new Habilidade();
                 habilidade.nome = txtNome.Text;
                 habilidade.descricao = txtDescricao.Text;

                sv.HabilidadeInsert(habilidade);
                MessageBox.Show("Habilidade cadastrada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None);
                ListaHabilidade();
            }
            catch(Exception ex)
            {
                throw ex;
            }         
        }        

        public void ListaHabilidade()
        {
            try
            {
                Service1 sv = new Service1();
                Habilidade habilidade = new Habilidade();
                listaHabilidade = sv.HabilidadeSelect(habilidade);
                listViewHabilidade.Items.Clear();

                foreach (Habilidade h in listaHabilidade)
                {
                    ListViewItem lvHabilidade = listViewHabilidade.Items.Add(h.id.ToString());
                    lvHabilidade.SubItems.Add(h.nome);
                    lvHabilidade.SubItems.Add(h.descricao);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }           
        }

        public void AtualizarHabilidade()
        {
            Habilidade habilidade = new Habilidade();
           // int index = listViewHabilidade.SelectedItems();
            
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            InserirHabilidade();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListaHabilidade();
        }

        private void listViewHabilidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
