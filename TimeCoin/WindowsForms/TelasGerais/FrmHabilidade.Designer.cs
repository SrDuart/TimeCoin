namespace WindowsForms.TelasGerais
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
            this.comboBoxNomeHabilidade = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.richTxtBoxOutras = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTxtBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxNomeHabilidade
            // 
            this.comboBoxNomeHabilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomeHabilidade.FormattingEnabled = true;
            this.comboBoxNomeHabilidade.Location = new System.Drawing.Point(126, 87);
            this.comboBoxNomeHabilidade.Name = "comboBoxNomeHabilidade";
            this.comboBoxNomeHabilidade.Size = new System.Drawing.Size(283, 28);
            this.comboBoxNomeHabilidade.TabIndex = 29;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(178, 308);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(47, 90);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(73, 20);
            this.lblTipoUsuario.TabIndex = 27;
            this.lblTipoUsuario.Text = "Habilidade";
            // 
            // richTxtBoxOutras
            // 
            this.richTxtBoxOutras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxOutras.Location = new System.Drawing.Point(126, 147);
            this.richTxtBoxOutras.Name = "richTxtBoxOutras";
            this.richTxtBoxOutras.Size = new System.Drawing.Size(283, 53);
            this.richTxtBoxOutras.TabIndex = 26;
            this.richTxtBoxOutras.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cadastre sua Habilidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Outras";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTxtBoxDescricao
            // 
            this.richTxtBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxDescricao.Location = new System.Drawing.Point(126, 224);
            this.richTxtBoxDescricao.Name = "richTxtBoxDescricao";
            this.richTxtBoxDescricao.Size = new System.Drawing.Size(283, 53);
            this.richTxtBoxDescricao.TabIndex = 33;
            this.richTxtBoxDescricao.Text = "";
            // 
            // FrmHabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.richTxtBoxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNomeHabilidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.richTxtBoxOutras);
            this.Name = "FrmHabilidade";
            this.Text = "FrmHabilidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNomeHabilidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.RichTextBox richTxtBoxOutras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTxtBoxDescricao;
    }
}