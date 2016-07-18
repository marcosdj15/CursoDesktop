namespace CursoDesktop2
{
    partial class FormInserirCliente
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.NuIdade = new System.Windows.Forms.NumericUpDown();
            this.lblIdade = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbEndereco);
            this.gbCliente.Controls.Add(this.lblEndereco);
            this.gbCliente.Controls.Add(this.gbSexo);
            this.gbCliente.Controls.Add(this.mtbTelefone);
            this.gbCliente.Controls.Add(this.lblTelefone);
            this.gbCliente.Controls.Add(this.NuIdade);
            this.gbCliente.Controls.Add(this.lblIdade);
            this.gbCliente.Controls.Add(this.tbNome);
            this.gbCliente.Controls.Add(this.lblNome);
            this.gbCliente.Controls.Add(this.tbCodigo);
            this.gbCliente.Controls.Add(this.lblCodigo);
            this.gbCliente.Location = new System.Drawing.Point(13, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(749, 357);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Novo Cliente";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(75, 232);
            this.tbEndereco.Multiline = true;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(668, 105);
            this.tbEndereco.TabIndex = 10;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 232);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Location = new System.Drawing.Point(10, 146);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(260, 65);
            this.gbSexo.TabIndex = 8;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(86, 20);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(80, 110);
            this.mtbTelefone.Mask = "(999) 000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 110);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.label1_Click);
            // 
            // NuIdade
            // 
            this.NuIdade.Location = new System.Drawing.Point(80, 79);
            this.NuIdade.Name = "NuIdade";
            this.NuIdade.Size = new System.Drawing.Size(120, 20);
            this.NuIdade.TabIndex = 5;
            this.NuIdade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(13, 81);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(80, 46);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(311, 20);
            this.tbNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(80, 17);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(83, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(13, 391);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(95, 391);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 2;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // FormInserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.gbCliente);
            this.Name = "FormInserirCliente";
            this.Text = "InserirCliente";
            this.Load += new System.EventHandler(this.FormInserirCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuIdade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.NumericUpDown NuIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInserir;
    }
}