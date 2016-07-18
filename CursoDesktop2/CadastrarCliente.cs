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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInserirCliente frlt = new FormInserirCliente();
            frlt.MdiParent = this.MdiParent;
            frlt.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
