namespace WindowsForms.TelasFrmPrincipal
{
    partial class FrmCadastrarUsuario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCpf_Cnpj = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelFixo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.richTxtBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.maskedTxtBoxCpf_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelCel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxHabilidadesDisponiveis = new System.Windows.Forms.ListBox();
            this.listBoxHabilidadeSelecionadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(36, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(387, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(107, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(126, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(18, 62);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 16);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Nome de Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(284, 59);
            this.txtSenha.MaxLength = 25;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(162, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(239, 63);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 16);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblCpf_Cnpj
            // 
            this.lblCpf_Cnpj.AutoSize = true;
            this.lblCpf_Cnpj.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf_Cnpj.Location = new System.Drawing.Point(239, 93);
            this.lblCpf_Cnpj.Name = "lblCpf_Cnpj";
            this.lblCpf_Cnpj.Size = new System.Drawing.Size(67, 16);
            this.lblCpf_Cnpj.TabIndex = 6;
            this.lblCpf_Cnpj.Text = "CPF / CNPJ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(33, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblTelFixo
            // 
            this.lblTelFixo.AutoSize = true;
            this.lblTelFixo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFixo.Location = new System.Drawing.Point(18, 122);
            this.lblTelFixo.Name = "lblTelFixo";
            this.lblTelFixo.Size = new System.Drawing.Size(73, 16);
            this.lblTelFixo.TabIndex = 11;
            this.lblTelFixo.Text = "Telefone Fixo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefone Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bairro";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(18, 152);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(23, 16);
            this.lblUf.TabIndex = 15;
            this.lblUf.Text = "UF";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(45, 148);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(37, 20);
            this.txtUf.TabIndex = 14;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(97, 151);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(42, 16);
            this.lblCidade.TabIndex = 19;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(141, 148);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(92, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // richTxtBoxDescricao
            // 
            this.richTxtBoxDescricao.Location = new System.Drawing.Point(21, 205);
            this.richTxtBoxDescricao.Name = "richTxtBoxDescricao";
            this.richTxtBoxDescricao.Size = new System.Drawing.Size(229, 74);
            this.richTxtBoxDescricao.TabIndex = 20;
            this.richTxtBoxDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(18, 183);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 16);
            this.lblDescricao.TabIndex = 21;
            this.lblDescricao.Text = "Descreva-se";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(256, 186);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(143, 16);
            this.lblTipoUsuario.TabIndex = 23;
            this.lblTipoUsuario.Text = "Selecione um tipo de usuario";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(178, 308);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 30);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(259, 205);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTipoUsuario.TabIndex = 25;
            // 
            // maskedTxtBoxCpf_Cnpj
            // 
            this.maskedTxtBoxCpf_Cnpj.Location = new System.Drawing.Point(312, 92);
            this.maskedTxtBoxCpf_Cnpj.Mask = "00000000000000";
            this.maskedTxtBoxCpf_Cnpj.Name = "maskedTxtBoxCpf_Cnpj";
            this.maskedTxtBoxCpf_Cnpj.Size = new System.Drawing.Size(134, 20);
            this.maskedTxtBoxCpf_Cnpj.TabIndex = 26;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(295, 149);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(151, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // maskedTxtBoxTelFixo
            // 
            this.maskedTxtBoxTelFixo.Location = new System.Drawing.Point(97, 121);
            this.maskedTxtBoxTelFixo.Mask = "0000000000";
            this.maskedTxtBoxTelFixo.Name = "maskedTxtBoxTelFixo";
            this.maskedTxtBoxTelFixo.Size = new System.Drawing.Size(134, 20);
            this.maskedTxtBoxTelFixo.TabIndex = 27;
            // 
            // maskedTxtBoxTelCel
            // 
            this.maskedTxtBoxTelCel.Location = new System.Drawing.Point(331, 121);
            this.maskedTxtBoxTelCel.Mask = "00000000000";
            this.maskedTxtBoxTelCel.Name = "maskedTxtBoxTelCel";
            this.maskedTxtBoxTelCel.Size = new System.Drawing.Size(115, 20);
            this.maskedTxtBoxTelCel.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Habilidades Disponíveis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxHabilidadesDisponiveis
            // 
            this.listBoxHabilidadesDisponiveis.FormattingEnabled = true;
            this.listBoxHabilidadesDisponiveis.Location = new System.Drawing.Point(464, 46);
            this.listBoxHabilidadesDisponiveis.Name = "listBoxHabilidadesDisponiveis";
            this.listBoxHabilidadesDisponiveis.Size = new System.Drawing.Size(194, 95);
            this.listBoxHabilidadesDisponiveis.TabIndex = 34;
            // 
            // listBoxHabilidadeSelecionadas
            // 
            this.listBoxHabilidadeSelecionadas.FormattingEnabled = true;
            this.listBoxHabilidadeSelecionadas.Location = new System.Drawing.Point(464, 205);
            this.listBoxHabilidadeSelecionadas.Name = "listBoxHabilidadeSelecionadas";
            this.listBoxHabilidadeSelecionadas.Size = new System.Drawing.Size(194, 95);
            this.listBoxHabilidadeSelecionadas.TabIndex = 35;
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 361);
            this.Controls.Add(this.listBoxHabilidadeSelecionadas);
            this.Controls.Add(this.listBoxHabilidadesDisponiveis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTxtBoxTelCel);
            this.Controls.Add(this.maskedTxtBoxTelFixo);
            this.Controls.Add(this.maskedTxtBoxCpf_Cnpj);
            this.Controls.Add(this.comboBoxTipoUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.richTxtBoxDescricao);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelFixo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCpf_Cnpj);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCpf_Cnpj;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelFixo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.RichTextBox richTxtBoxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCpf_Cnpj;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelFixo;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelCel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxHabilidadesDisponiveis;
        private System.Windows.Forms.ListBox listBoxHabilidadeSelecionadas;
    }
}