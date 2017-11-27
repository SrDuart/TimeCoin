namespace WindowsForms.TelasFrmUsuario
{
    partial class FrmConsultarAnuncio
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
            this.lblTipoAnuncio = new System.Windows.Forms.Label();
            this.lblTipoAnunciante = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.comboBoxTipoAnuncio = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoAnunciante = new System.Windows.Forms.ComboBox();
            this.comboBoxLocalidade = new System.Windows.Forms.ComboBox();
            this.listBoxConsulta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTipoAnuncio
            // 
            this.lblTipoAnuncio.AutoSize = true;
            this.lblTipoAnuncio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnuncio.Location = new System.Drawing.Point(12, 9);
            this.lblTipoAnuncio.Name = "lblTipoAnuncio";
            this.lblTipoAnuncio.Size = new System.Drawing.Size(107, 20);
            this.lblTipoAnuncio.TabIndex = 0;
            this.lblTipoAnuncio.Text = "Tipo de Anúncio";
            // 
            // lblTipoAnunciante
            // 
            this.lblTipoAnunciante.AutoSize = true;
            this.lblTipoAnunciante.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnunciante.Location = new System.Drawing.Point(12, 46);
            this.lblTipoAnunciante.Name = "lblTipoAnunciante";
            this.lblTipoAnunciante.Size = new System.Drawing.Size(124, 20);
            this.lblTipoAnunciante.TabIndex = 1;
            this.lblTipoAnunciante.Text = "Tipo de Anunciante";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidade.Location = new System.Drawing.Point(12, 83);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(75, 20);
            this.lblLocalidade.TabIndex = 2;
            this.lblLocalidade.Text = "Localidade";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(179, 303);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // comboBoxTipoAnuncio
            // 
            this.comboBoxTipoAnuncio.FormattingEnabled = true;
            this.comboBoxTipoAnuncio.Location = new System.Drawing.Point(125, 11);
            this.comboBoxTipoAnuncio.Name = "comboBoxTipoAnuncio";
            this.comboBoxTipoAnuncio.Size = new System.Drawing.Size(319, 21);
            this.comboBoxTipoAnuncio.TabIndex = 5;
            // 
            // comboBoxTipoAnunciante
            // 
            this.comboBoxTipoAnunciante.FormattingEnabled = true;
            this.comboBoxTipoAnunciante.Location = new System.Drawing.Point(142, 48);
            this.comboBoxTipoAnunciante.Name = "comboBoxTipoAnunciante";
            this.comboBoxTipoAnunciante.Size = new System.Drawing.Size(302, 21);
            this.comboBoxTipoAnunciante.TabIndex = 6;
            // 
            // comboBoxLocalidade
            // 
            this.comboBoxLocalidade.FormattingEnabled = true;
            this.comboBoxLocalidade.Location = new System.Drawing.Point(93, 85);
            this.comboBoxLocalidade.Name = "comboBoxLocalidade";
            this.comboBoxLocalidade.Size = new System.Drawing.Size(351, 21);
            this.comboBoxLocalidade.TabIndex = 7;
            // 
            // listBoxConsulta
            // 
            this.listBoxConsulta.FormattingEnabled = true;
            this.listBoxConsulta.Location = new System.Drawing.Point(16, 133);
            this.listBoxConsulta.Name = "listBoxConsulta";
            this.listBoxConsulta.Size = new System.Drawing.Size(428, 134);
            this.listBoxConsulta.TabIndex = 8;
            // 
            // FrmConsultarAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.listBoxConsulta);
            this.Controls.Add(this.comboBoxLocalidade);
            this.Controls.Add(this.comboBoxTipoAnunciante);
            this.Controls.Add(this.comboBoxTipoAnuncio);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblLocalidade);
            this.Controls.Add(this.lblTipoAnunciante);
            this.Controls.Add(this.lblTipoAnuncio);
            this.Name = "FrmConsultarAnuncio";
            this.Text = "Consultar Anúncio";
            this.Load += new System.EventHandler(this.FrmConsultarAnuncio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoAnuncio;
        private System.Windows.Forms.Label lblTipoAnunciante;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox comboBoxTipoAnuncio;
        private System.Windows.Forms.ComboBox comboBoxTipoAnunciante;
        private System.Windows.Forms.ComboBox comboBoxLocalidade;
        private System.Windows.Forms.ListBox listBoxConsulta;
    }
}