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
            this.btnSituacao = new System.Windows.Forms.Button();
            this.btnRecebe = new System.Windows.Forms.Button();
            this.btnPresta = new System.Windows.Forms.Button();
            this.btnHabilidade = new System.Windows.Forms.Button();
            this.btnAnuncio = new System.Windows.Forms.Button();
            this.btnConsultaAnuncio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSituacao
            // 
            this.btnSituacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSituacao.Location = new System.Drawing.Point(326, 222);
            this.btnSituacao.Name = "btnSituacao";
            this.btnSituacao.Size = new System.Drawing.Size(180, 100);
            this.btnSituacao.TabIndex = 16;
            this.btnSituacao.Text = "Situação";
            this.btnSituacao.UseVisualStyleBackColor = true;
            // 
            // btnRecebe
            // 
            this.btnRecebe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecebe.Location = new System.Drawing.Point(75, 222);
            this.btnRecebe.Name = "btnRecebe";
            this.btnRecebe.Size = new System.Drawing.Size(180, 100);
            this.btnRecebe.TabIndex = 14;
            this.btnRecebe.Text = "Serviço Recebido";
            this.btnRecebe.UseVisualStyleBackColor = true;
            // 
            // btnPresta
            // 
            this.btnPresta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresta.Location = new System.Drawing.Point(570, 67);
            this.btnPresta.Name = "btnPresta";
            this.btnPresta.Size = new System.Drawing.Size(180, 100);
            this.btnPresta.TabIndex = 13;
            this.btnPresta.Text = "Serviço Prestado";
            this.btnPresta.UseVisualStyleBackColor = true;
            // 
            // btnHabilidade
            // 
            this.btnHabilidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilidade.Location = new System.Drawing.Point(326, 67);
            this.btnHabilidade.Name = "btnHabilidade";
            this.btnHabilidade.Size = new System.Drawing.Size(180, 100);
            this.btnHabilidade.TabIndex = 12;
            this.btnHabilidade.Text = "Habilidade";
            this.btnHabilidade.UseVisualStyleBackColor = true;
            this.btnHabilidade.Click += new System.EventHandler(this.btnHabilidade_Click);
            // 
            // btnAnuncio
            // 
            this.btnAnuncio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuncio.Location = new System.Drawing.Point(75, 67);
            this.btnAnuncio.Name = "btnAnuncio";
            this.btnAnuncio.Size = new System.Drawing.Size(180, 100);
            this.btnAnuncio.TabIndex = 11;
            this.btnAnuncio.Text = "Anúncio";
            this.btnAnuncio.UseVisualStyleBackColor = true;
            this.btnAnuncio.Click += new System.EventHandler(this.btnAnuncio_Click);
            // 
            // btnConsultaAnuncio
            // 
            this.btnConsultaAnuncio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaAnuncio.Location = new System.Drawing.Point(570, 222);
            this.btnConsultaAnuncio.Name = "btnConsultaAnuncio";
            this.btnConsultaAnuncio.Size = new System.Drawing.Size(180, 100);
            this.btnConsultaAnuncio.TabIndex = 17;
            this.btnConsultaAnuncio.Text = "Consultar Anúncios";
            this.btnConsultaAnuncio.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 373);
            this.Controls.Add(this.btnConsultaAnuncio);
            this.Controls.Add(this.btnSituacao);
            this.Controls.Add(this.btnRecebe);
            this.Controls.Add(this.btnPresta);
            this.Controls.Add(this.btnHabilidade);
            this.Controls.Add(this.btnAnuncio);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeCoin";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSituacao;
        private System.Windows.Forms.Button btnRecebe;
        private System.Windows.Forms.Button btnPresta;
        private System.Windows.Forms.Button btnHabilidade;
        private System.Windows.Forms.Button btnAnuncio;
        private System.Windows.Forms.Button btnConsultaAnuncio;
    }
}