namespace CursoDesktop2
{
    partial class FromPrincipal
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
            this.btInserirCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInserirCliente
            // 
            this.btInserirCliente.Location = new System.Drawing.Point(97, 114);
            this.btInserirCliente.Name = "btInserirCliente";
            this.btInserirCliente.Size = new System.Drawing.Size(75, 23);
            this.btInserirCliente.TabIndex = 0;
            this.btInserirCliente.Text = "Inserir";
            this.btInserirCliente.UseVisualStyleBackColor = true;
            this.btInserirCliente.Click += new System.EventHandler(this.btInserirCliente_Click);
            // 
            // FromPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btInserirCliente);
            this.Name = "FromPrincipal";
            this.Text = "Aplicação do Curso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInserirCliente;

    }
}

