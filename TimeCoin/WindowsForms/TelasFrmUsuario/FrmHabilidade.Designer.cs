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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDescricaoHabilidade;
    }
}