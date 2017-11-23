using System;
using System.Windows.Forms;
using System.Web.Services;
using System.Data.SqlClient;
using WcfService;

namespace WindowsForms
{
    public partial class FrmLogin : Form
    {
        SqlConnection sqlConexao = null;
        //private 

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1 serv = new Service1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
