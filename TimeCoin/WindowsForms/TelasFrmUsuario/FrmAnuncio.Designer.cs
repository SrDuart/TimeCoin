namespace WindowsForms.TelasFrmUsuario
{
    partial class FrmAnuncio
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.richTxtBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.lblPreRequisito = new System.Windows.Forms.Label();
            this.txtPreRequisito = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtTipoAnuncio = new System.Windows.Forms.TextBox();
            this.lblTipoAnuncio = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.richTxtBoxServico = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(18, 148);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(66, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(173, 319);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // richTxtBoxDescricao
            // 
            this.richTxtBoxDescricao.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxDescricao.Location = new System.Drawing.Point(90, 148);
            this.richTxtBoxDescricao.Name = "richTxtBoxDescricao";
            this.richTxtBoxDescricao.Size = new System.Drawing.Size(142, 147);
            this.richTxtBoxDescricao.TabIndex = 3;
            this.richTxtBoxDescricao.Text = "";
            // 
            // lblPreRequisito
            // 
            this.lblPreRequisito.AutoSize = true;
            this.lblPreRequisito.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreRequisito.Location = new System.Drawing.Point(18, 27);
            this.lblPreRequisito.Name = "lblPreRequisito";
            this.lblPreRequisito.Size = new System.Drawing.Size(84, 20);
            this.lblPreRequisito.TabIndex = 6;
            this.lblPreRequisito.Text = "Pré-Requisito";
            this.lblPreRequisito.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPreRequisito
            // 
            this.txtPreRequisito.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreRequisito.Location = new System.Drawing.Point(108, 27);
            this.txtPreRequisito.Name = "txtPreRequisito";
            this.txtPreRequisito.Size = new System.Drawing.Size(332, 21);
            this.txtPreRequisito.TabIndex = 5;
            this.txtPreRequisito.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(18, 69);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(26, 20);
            this.lblUf.TabIndex = 8;
            this.lblUf.Text = "UF";
            this.lblUf.Click += new System.EventHandler(this.lblUf_Click);
            // 
            // txtUf
            // 
            this.txtUf.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(50, 70);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(27, 21);
            this.txtUf.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(92, 69);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(49, 20);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(147, 69);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(107, 21);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(272, 69);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 20);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(320, 69);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(120, 21);
            this.txtBairro.TabIndex = 11;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(82, 106);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(107, 21);
            this.txtSituacao.TabIndex = 15;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(18, 106);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(58, 20);
            this.lblSituacao.TabIndex = 14;
            this.lblSituacao.Text = "Situação";
            // 
            // txtTipoAnuncio
            // 
            this.txtTipoAnuncio.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoAnuncio.Location = new System.Drawing.Point(320, 106);
            this.txtTipoAnuncio.Name = "txtTipoAnuncio";
            this.txtTipoAnuncio.Size = new System.Drawing.Size(120, 21);
            this.txtTipoAnuncio.TabIndex = 17;
            // 
            // lblTipoAnuncio
            // 
            this.lblTipoAnuncio.AutoSize = true;
            this.lblTipoAnuncio.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnuncio.Location = new System.Drawing.Point(214, 107);
            this.lblTipoAnuncio.Name = "lblTipoAnuncio";
            this.lblTipoAnuncio.Size = new System.Drawing.Size(100, 20);
            this.lblTipoAnuncio.TabIndex = 16;
            this.lblTipoAnuncio.Text = "Tipo do Anúncio";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(242, 148);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(50, 20);
            this.lblServico.TabIndex = 18;
            this.lblServico.Text = "Serviço";
            // 
            // richTxtBoxServico
            // 
            this.richTxtBoxServico.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxServico.Location = new System.Drawing.Point(298, 148);
            this.richTxtBoxServico.Name = "richTxtBoxServico";
            this.richTxtBoxServico.Size = new System.Drawing.Size(142, 147);
            this.richTxtBoxServico.TabIndex = 19;
            this.richTxtBoxServico.Text = "";
            // 
            // FrmAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.richTxtBoxServico);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.txtTipoAnuncio);
            this.Controls.Add(this.lblTipoAnuncio);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.lblPreRequisito);
            this.Controls.Add(this.txtPreRequisito);
            this.Controls.Add(this.richTxtBoxDescricao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDescricao);
            this.Name = "FrmAnuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Anúncio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RichTextBox richTxtBoxDescricao;
        private System.Windows.Forms.Label lblPreRequisito;
        private System.Windows.Forms.TextBox txtPreRequisito;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtTipoAnuncio;
        private System.Windows.Forms.Label lblTipoAnuncio;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.RichTextBox richTxtBoxServico;
    }
}