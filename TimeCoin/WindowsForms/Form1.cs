using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Usuario tipousuario = new localhost.Usuario();
            localhost.Service1 sv = new localhost.Service1();

            tipousuario.nomek__BackingField = "Fernando";
            tipousuario.cpf_cnpjk__BackingField = "12345677897";
            tipousuario.userNamek__BackingField = "jf";
            sv.UsuarioUpdate(tipousuario);
            
        }
    }
}