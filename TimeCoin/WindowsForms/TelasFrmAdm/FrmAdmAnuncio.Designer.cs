namespace WindowsForms.TelasFrmAdm
{
    partial class FrmAdmAnuncio
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.listViewAnuncio = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPreRequisito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(246, 23);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(18, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(22, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 21);
            this.txtId.TabIndex = 2;
            // 
            // listViewAnuncio
            // 
            this.listViewAnuncio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderDescricao,
            this.columnHeaderData,
            this.columnHeaderPreRequisito,
            this.columnHeaderUf,
            this.columnHeaderCidade,
            this.columnHeaderBairro});
            this.listViewAnuncio.Location = new System.Drawing.Point(1, 145);
            this.listViewAnuncio.Name = "listViewAnuncio";
            this.listViewAnuncio.Size = new System.Drawing.Size(461, 215);
            this.listViewAnuncio.TabIndex = 3;
            this.listViewAnuncio.UseCompatibleStateImageBehavior = false;
            this.listViewAnuncio.View = System.Windows.Forms.View.Details;
            this.listViewAnuncio.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descrição";
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            // 
            // columnHeaderPreRequisito
            // 
            this.columnHeaderPreRequisito.Text = "Pré-Requisito";
            this.columnHeaderPreRequisito.Width = 81;
            // 
            // columnHeaderUf
            // 
            this.columnHeaderUf.Text = "UF";
            // 
            // columnHeaderCidade
            // 
            this.columnHeaderCidade.Text = "Cidade";
            // 
            // columnHeaderBairro
            // 
            this.columnHeaderBairro.Text = "Bairro";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(22, 87);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 21);
            this.txtData.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(19, 64);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(352, 59);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(246, 59);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(352, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionar.Location = new System.Drawing.Point(3, 129);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(247, 13);
            this.lblSelecionar.TabIndex = 9;
            this.lblSelecionar.Text = "Dê um duplo click para selecionar um item";
            // 
            // FrmAdmAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listViewAnuncio);
            this.Name = "FrmAdmAnuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro dos Anúncios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ListView listViewAnuncio;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderPreRequisito;
        private System.Windows.Forms.ColumnHeader columnHeaderUf;
        private System.Windows.Forms.ColumnHeader columnHeaderCidade;
        private System.Windows.Forms.ColumnHeader columnHeaderBairro;
    }
}