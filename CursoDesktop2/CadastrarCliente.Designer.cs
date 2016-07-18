namespace CursoDesktop2
{
    partial class CadastrarCliente
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
            this.lblNomeCC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.jbtInserir = new System.Windows.Forms.Button();
            this.jbtRemover = new System.Windows.Forms.Button();
            this.jbtConsultar = new System.Windows.Forms.Button();
            this.jbtLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCC
            // 
            this.lblNomeCC.AutoSize = true;
            this.lblNomeCC.Location = new System.Drawing.Point(13, 13);
            this.lblNomeCC.Name = "lblNomeCC";
            this.lblNomeCC.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCC.TabIndex = 0;
            this.lblNomeCC.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(666, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // jbtInserir
            // 
            this.jbtInserir.Location = new System.Drawing.Point(664, 52);
            this.jbtInserir.Name = "jbtInserir";
            this.jbtInserir.Size = new System.Drawing.Size(75, 23);
            this.jbtInserir.TabIndex = 2;
            this.jbtInserir.Text = "Inserir";
            this.jbtInserir.UseVisualStyleBackColor = true;
            this.jbtInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // jbtRemover
            // 
            this.jbtRemover.Location = new System.Drawing.Point(583, 52);
            this.jbtRemover.Name = "jbtRemover";
            this.jbtRemover.Size = new System.Drawing.Size(75, 23);
            this.jbtRemover.TabIndex = 3;
            this.jbtRemover.Text = "Remover";
            this.jbtRemover.UseVisualStyleBackColor = true;
            this.jbtRemover.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // jbtConsultar
            // 
            this.jbtConsultar.Location = new System.Drawing.Point(502, 52);
            this.jbtConsultar.Name = "jbtConsultar";
            this.jbtConsultar.Size = new System.Drawing.Size(75, 23);
            this.jbtConsultar.TabIndex = 4;
            this.jbtConsultar.Text = "Consultar";
            this.jbtConsultar.UseVisualStyleBackColor = true;
            // 
            // jbtLimpar
            // 
            this.jbtLimpar.Location = new System.Drawing.Point(421, 52);
            this.jbtLimpar.Name = "jbtLimpar";
            this.jbtLimpar.Size = new System.Drawing.Size(75, 23);
            this.jbtLimpar.TabIndex = 5;
            this.jbtLimpar.Text = "Limpar";
            this.jbtLimpar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 108);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(114, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado da Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 272);
            this.dataGridView1.TabIndex = 7;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.jbtLimpar);
            this.Controls.Add(this.jbtConsultar);
            this.Controls.Add(this.jbtRemover);
            this.Controls.Add(this.jbtInserir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomeCC);
            this.Name = "CadastrarCliente";
            this.Text = "Cadastrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button jbtInserir;
        private System.Windows.Forms.Button jbtRemover;
        private System.Windows.Forms.Button jbtConsultar;
        private System.Windows.Forms.Button jbtLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}