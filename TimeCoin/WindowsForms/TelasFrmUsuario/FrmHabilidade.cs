using System;
using System.Windows.Forms;
using WindowsForms.localhost;

namespace WindowsForms.TelasFrmUsuario
{
    public partial class FrmHabilidade : Form
    {
        public FrmHabilidade()
        {
            InitializeComponent();
        }

        public void CadastrarHabilidade()
        {
            Service1 sv = new Service1();
            Habilidade habilidade = new Habilidade();

            try
            {
                #region Atribuição de valores
                habilidade.nome = txtNomeHabilidade.Text;
                habilidade.descricao = richTxtBoxDescricaoHabilidade.Text;
                #endregion

                sv.HabilidadeInsert(habilidade);

                MessageBox.Show("Habilidade cadastrada com sucesso!");

                this.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarHabilidade();
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.ShowDialog();
            
            FrmHabilidade habilidade = new FrmHabilidade();
            this.Close();
        }
    }
}
