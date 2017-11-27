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
            this.txtData = new System.Windows.Forms.TextBox();
            this.richTxtBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPreRequisito = new System.Windows.Forms.Label();
            this.txtPreRequisito = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(28, 157);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(66, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(173, 308);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(73, 27);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 21);
            this.txtData.TabIndex = 2;
            // 
            // richTxtBoxDescricao
            // 
            this.richTxtBoxDescricao.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxDescricao.Location = new System.Drawing.Point(110, 157);
            this.richTxtBoxDescricao.Name = "richTxtBoxDescricao";
            this.richTxtBoxDescricao.Size = new System.Drawing.Size(326, 120);
            this.richTxtBoxDescricao.TabIndex = 3;
            this.richTxtBoxDescricao.Text = "";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(28, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // lblPreRequisito
            // 
            this.lblPreRequisito.AutoSize = true;
            this.lblPreRequisito.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreRequisito.Location = new System.Drawing.Point(28, 69);
            this.lblPreRequisito.Name = "lblPreRequisito";
            this.lblPreRequisito.Size = new System.Drawing.Size(84, 20);
            this.lblPreRequisito.TabIndex = 6;
            this.lblPreRequisito.Text = "Pré-Requisito";
            this.lblPreRequisito.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPreRequisito
            // 
            this.txtPreRequisito.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreRequisito.Location = new System.Drawing.Point(118, 68);
            this.txtPreRequisito.Name = "txtPreRequisito";
            this.txtPreRequisito.Size = new System.Drawing.Size(318, 21);
            this.txtPreRequisito.TabIndex = 5;
            this.txtPreRequisito.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(28, 109);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(26, 20);
            this.lblUf.TabIndex = 8;
            this.lblUf.Text = "UF";
            // 
            // txtUf
            // 
            this.txtUf.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(60, 109);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(27, 21);
            this.txtUf.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(99, 109);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(49, 20);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(154, 109);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(107, 21);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(279, 109);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 20);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(327, 109);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(109, 21);
            this.txtBairro.TabIndex = 11;
            // 
            // FrmAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.lblPreRequisito);
            this.Controls.Add(this.txtPreRequisito);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.richTxtBoxDescricao);
            this.Controls.Add(this.txtData);
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
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.RichTextBox richTxtBoxDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPreRequisito;
        private System.Windows.Forms.TextBox txtPreRequisito;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
    }
}