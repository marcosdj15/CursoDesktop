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
    public partial class FromPrincipal : Form
    {
        public FromPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btInserirCliente_Click(object sender, EventArgs e)
        {
            FormInserirCliente flr = new FormInserirCliente();
            flr.Visible = true;
            this.Visible = false;
            
           
        }
    }
}
