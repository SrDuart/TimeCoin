using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmAdm
{
    public partial class FrmAdmHabilidade : Form
    {
        Habilidade[] listaHabilidade;
        Habilidade habilidadeSelecionada;
        
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
                LimparCampos();
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

        public Habilidade SelecionarHabilidade()
        {
            try
            {                
               int posicao = listViewHabilidade.FocusedItem.Index;
               habilidadeSelecionada = this.listaHabilidade[posicao];                   
                
                return habilidadeSelecionada;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirHabilidade()
        {
            if (listViewHabilidade.FocusedItem != null)
            {
                try
                {
                    DialogResult mens = MessageBox.Show("Lembre-se que DBA não permitirá excluir habilidades vinculadas a outra tabela. Deseja excluir está habilidade ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mens == DialogResult.Yes)
                    {
                        Service1 sv = new Service1();
                        sv.HabilidadeDelete(SelecionarHabilidade());
                        MessageBox.Show("Habilidade deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ListaHabilidade();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar uma habilidade da lista abaixo.");
            }
        }

        public void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        public void AtualizarHabilidade()
        {
            try
            {
                Service1 sv = new Service1();
                Habilidade habilidade = new Habilidade();
                habilidade.id = Convert.ToInt32(txtId.Text);
                habilidade.nome = txtNome.Text;
                habilidade.descricao = txtDescricao.Text;
                sv.HabilidadeUpdate(habilidade);
                MessageBox.Show("Habilidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                btnConfirmar.Enabled = false;
                LimparCampos();
                ListaHabilidade();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            InserirHabilidade();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ListaHabilidade();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            AtualizarHabilidade();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirHabilidade();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (listViewHabilidade.FocusedItem != null)
            {
                SelecionarHabilidade();
                txtId.Text = Convert.ToString(habilidadeSelecionada.id);
                txtNome.Text = habilidadeSelecionada.nome;
                txtDescricao.Text = habilidadeSelecionada.descricao;
                btnConfirmar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Favor selecionar uma habilidade da lista abaixo.");
            }
        }
    }
}
