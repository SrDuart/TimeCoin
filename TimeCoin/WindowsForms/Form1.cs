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
            localhost.Service1 sv = new localhost.Service1();             
            String info = textBox1.Text;            
            //sv.TipoUsuarioInsert(tipoUsuario, info);
            
        }
    }
}