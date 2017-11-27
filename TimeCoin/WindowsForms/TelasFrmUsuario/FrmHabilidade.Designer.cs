namespace WindowsForms.TelasFrmUsuario
{
    partial class FrmHabilidade
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
            this.lblNomeHabilidade = new System.Windows.Forms.Label();
            this.richTxtBoxDescricaoHabilidade = new System.Windows.Forms.RichTextBox();
            this.txtNomeHabilidade = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblDescricaoHabilidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeHabilidade
            // 
            this.lblNomeHabilidade.AutoSize = true;
            this.lblNomeHabilidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeHabilidade.Location = new System.Drawing.Point(29, 63);
            this.lblNomeHabilidade.Name = "lblNomeHabilidade";
            this.lblNomeHabilidade.Size = new System.Drawing.Size(132, 20);
            this.lblNomeHabilidade.TabIndex = 0;
            this.lblNomeHabilidade.Text = "Nome da Habilidade";
            // 
            // richTxtBoxDescricaoHabilidade
            // 
            this.richTxtBoxDescricaoHabilidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxDescricaoHabilidade.Location = new System.Drawing.Point(204, 125);
            this.richTxtBoxDescricaoHabilidade.Name = "richTxtBoxDescricaoHabilidade";
            this.richTxtBoxDescricaoHabilidade.Size = new System.Drawing.Size(223, 126);
            this.richTxtBoxDescricaoHabilidade.TabIndex = 1;
            this.richTxtBoxDescricaoHabilidade.Text = "";
            // 
            // txtNomeHabilidade
            // 
            this.txtNomeHabilidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeHabilidade.Location = new System.Drawing.Point(167, 60);
            this.txtNomeHabilidade.Name = "txtNomeHabilidade";
            this.txtNomeHabilidade.Size = new System.Drawing.Size(260, 26);
            this.txtNomeHabilidade.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(179, 299);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDescricaoHabilidade
            // 
            this.lblDescricaoHabilidade.AutoSize = true;
            this.lblDescricaoHabilidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoHabilidade.Location = new System.Drawing.Point(29, 172);
            this.lblDescricaoHabilidade.Name = "lblDescricaoHabilidade";
            this.lblDescricaoHabilidade.Size = new System.Drawing.Size(156, 20);
            this.lblDescricaoHabilidade.TabIndex = 4;
            this.lblDescricaoHabilidade.Text = "Descrição da Habilidade";
            // 
            // FrmHabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.lblDescricaoHabilidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNomeHabilidade);
            this.Controls.Add(this.richTxtBoxDescricaoHabilidade);
            this.Controls.Add(this.lblNomeHabilidade);
            this.Name = "FrmHabilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Habilidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeHabilidade;
        private System.Windows.Forms.RichTextBox richTxtBoxDescricaoHabilidade;
        private System.Windows.Forms.TextBox txtNomeHabilidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDescricaoHabilidade;
    }
}