using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDesktop2
{
    public partial class FormInserirCliente : Form
    {
        public FormInserirCliente()
        {
            InitializeComponent();
        }

        private void FormInserirCliente_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
           
            Cliente cli = new Cliente();
            cli.nome = tbNome.Text;
            cli.idade = Convert.ToInt16(NuIdade.Value.ToString());
            cli.telefone = mtbTelefone.Text;
            cli.endereco = tbEndereco.Text;
            cli.sexo = (rbMasculino.Checked ? 'M' : 'F');
            MessageBox.Show("Cadastro Realizado com Sucesso !!","Messagem de Ok",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            this.Close();
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Text = "";
            NuIdade.Value = 0;
            tbEndereco.Text = "";
            mtbTelefone.Text = "";
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
        }
    }
}
////