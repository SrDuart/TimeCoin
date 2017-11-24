namespace WindowsForms.TelasFrmUsuario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuHabilidade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnuncio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServiçoPrestado = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuServiçoRecebido = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReclameAqui = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHabilidade,
            this.MenuAnuncio,
            this.MenuServiçoPrestado,
            this.MenuServiçoRecebido,
            this.MenuReclameAqui,
            this.MenuLogout});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(165, 158);
            this.Menu.Text = "Menu";
            this.Menu.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Opening_1);
            // 
            // MenuHabilidade
            // 
            this.MenuHabilidade.Name = "MenuHabilidade";
            this.MenuHabilidade.Size = new System.Drawing.Size(164, 22);
            this.MenuHabilidade.Text = "Habilidades";
            this.MenuHabilidade.Click += new System.EventHandler(this.MenuHabilidade_Click);
            // 
            // MenuAnuncio
            // 
            this.MenuAnuncio.Name = "MenuAnuncio";
            this.MenuAnuncio.Size = new System.Drawing.Size(164, 22);
            this.MenuAnuncio.Text = "Anúncios";
            // 
            // MenuServiçoPrestado
            // 
            this.MenuServiçoPrestado.Name = "MenuServiçoPrestado";
            this.MenuServiçoPrestado.Size = new System.Drawing.Size(164, 22);
            this.MenuServiçoPrestado.Text = "Serviço Prestado";
            // 
            // MenuServiçoRecebido
            // 
            this.MenuServiçoRecebido.Name = "MenuServiçoRecebido";
            this.MenuServiçoRecebido.Size = new System.Drawing.Size(164, 22);
            this.MenuServiçoRecebido.Text = "Serviço Recebido";
            // 
            // MenuReclameAqui
            // 
            this.MenuReclameAqui.Name = "MenuReclameAqui";
            this.MenuReclameAqui.Size = new System.Drawing.Size(164, 22);
            this.MenuReclameAqui.Text = "Reclame Aqui";
            // 
            // MenuLogout
            // 
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(164, 22);
            this.MenuLogout.Text = "Logout";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 701);
            this.Name = "FrmPrincipal";
            this.Text = "TimeCoin";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuHabilidade;
        private System.Windows.Forms.ToolStripMenuItem MenuAnuncio;
        private System.Windows.Forms.ToolStripMenuItem MenuServiçoPrestado;
        private System.Windows.Forms.ToolStripMenuItem MenuServiçoRecebido;
        private System.Windows.Forms.ToolStripMenuItem MenuReclameAqui;
        private System.Windows.Forms.ToolStripMenuItem MenuLogout;
    }
}