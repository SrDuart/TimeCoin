namespace WindowsForms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadasroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeHabilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAnúncioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuáriosToolStripMenuItem,
            this.cadasroDeUsuáriosToolStripMenuItem,
            this.cadastroDeHabilidadesToolStripMenuItem,
            this.cadastrarAnúncioToolStripMenuItem,
            this.cadastrarServiçoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastrar Tipo de Usuários";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuáriosToolStripMenuItem_Click);
            // 
            // cadasroDeUsuáriosToolStripMenuItem
            // 
            this.cadasroDeUsuáriosToolStripMenuItem.Name = "cadasroDeUsuáriosToolStripMenuItem";
            this.cadasroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadasroDeUsuáriosToolStripMenuItem.Text = "Cadastrar Usuários";
            // 
            // cadastroDeHabilidadesToolStripMenuItem
            // 
            this.cadastroDeHabilidadesToolStripMenuItem.Name = "cadastroDeHabilidadesToolStripMenuItem";
            this.cadastroDeHabilidadesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastroDeHabilidadesToolStripMenuItem.Text = "Cadastrar Habilidades";
            this.cadastroDeHabilidadesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeHabilidadesToolStripMenuItem_Click);
            // 
            // cadastrarAnúncioToolStripMenuItem
            // 
            this.cadastrarAnúncioToolStripMenuItem.Name = "cadastrarAnúncioToolStripMenuItem";
            this.cadastrarAnúncioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastrarAnúncioToolStripMenuItem.Text = "Cadastrar Anúncio";
            // 
            // cadastrarServiçoToolStripMenuItem
            // 
            this.cadastrarServiçoToolStripMenuItem.Name = "cadastrarServiçoToolStripMenuItem";
            this.cadastrarServiçoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cadastrarServiçoToolStripMenuItem.Text = "Cadastrar Serviço";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "TimeCoin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadasroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeHabilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAnúncioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarServiçoToolStripMenuItem;
    }
}

