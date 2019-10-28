using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class frmGrupoMuscular : Form
    {
        public frmGrupoMuscular()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGrupoMuscular.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
