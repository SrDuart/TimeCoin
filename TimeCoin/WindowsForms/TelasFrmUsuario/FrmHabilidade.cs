using System;
using System.Windows.Forms;
using WcfService.localhost;

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
                habilidade.nome = comboBoxNomeHabilidade.Text;
                habilidade.nome = richTxtBoxOutras.Text;
                habilidade.descricao = richTxtBoxDescricao.Text;
                #endregion

                sv.HabilidadeInsert(habilidade);

                MessageBox.Show("Habilidade cadastrada com sucesso!");

                this.Close();

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarHabilidade();
            FrmPrincipal principal = new FrmPrincipal();
        }

        private void comboBoxNomeHabilidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
