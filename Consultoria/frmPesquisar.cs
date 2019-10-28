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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataSource = pedidosBindigSource
            SelectionMode = FullRowSelect*/
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pedidosBindingSource.Filter = string.Format("pedido_CD={0}", textBox1.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pedidosBindingSource.RemoveCurrent();
                pedidosTableAdapter.Update(superMercadoDataSet.pedidos); //salvar
                this.pedidosTableAdapter.Fill(this.superMercadoDataSet.pedidos);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            Form5 newform5 = new Form5();
            newform5.ShowDialog();
        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultoriaDataSet.cad_Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_AlunosTableAdapter.Fill(this.consultoriaDataSet.cad_Alunos);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataSource = pedidosBindigSource
          SelectionMode = FullRowSelect
        }
    }
}
