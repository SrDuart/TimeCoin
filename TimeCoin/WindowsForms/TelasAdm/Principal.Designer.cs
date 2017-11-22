namespace WindowsForms.TelasAdm
{
    partial class Principal
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
            this.buttonTipoUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTipoUsuario
            // 
            this.buttonTipoUsuario.Location = new System.Drawing.Point(91, 111);
            this.buttonTipoUsuario.Name = "buttonTipoUsuario";
            this.buttonTipoUsuario.Size = new System.Drawing.Size(150, 90);
            this.buttonTipoUsuario.TabIndex = 0;
            this.buttonTipoUsuario.Text = "TipoUsuario";
            this.buttonTipoUsuario.UseVisualStyleBackColor = true;
            this.buttonTipoUsuario.Click += new System.EventHandler(this.buttonTipoUsuario_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 733);
            this.Controls.Add(this.buttonTipoUsuario);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTipoUsuario;
    }
}