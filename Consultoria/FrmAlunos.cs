using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Consultoria
{
    public partial class FrmAlunos : Form
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultoriaDataSet.cad_Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_AlunosTableAdapter.Fill(this.consultoriaDataSet.cad_Alunos);
            cadAlunosBindingSource.AddNew();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtCel.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtPeso.Clear();
            txtPlanos1.Clear();
            mskCPF.Clear();
            mskRG.Clear();
            pcbImagem.Image = null;
            cmbPlanos.SelectedIndex = -1;
            mskValor1.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // PARA O TREINADOR PREENCHER TODOS OS CAMPOS DE CADASTRO


            if (txtAltura.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com a Altura");
                txtAltura.Focus();
            }

            else if(txtPeso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Peso");
                txtPeso.Focus();
            }

            else if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Nome");
                txtNome.Focus();
            }
            else if (txtIdade.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com a Idade");
                txtIdade.Focus();
            }

            else if (txtCel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Telefone");
                txtCel.Focus();
            }

            else if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Email");
                txtEmail.Focus();
            }
            else if(txtEndereco.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Endereço");
                txtEndereco.Focus();
            }

            else if (mskCEP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o CEP");
                mskCEP.Focus();
            }

            else if (mskCPF.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o CPF");
                mskCPF.Focus();
            }

            else if (mskRG.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o RG");
                mskRG.Focus();
            }

            // PARA CADASTRAR!!!

            cadAlunosBindingSource.EndEdit();
            cad_AlunosTableAdapter.Update(consultoriaDataSet.cad_Alunos);
            this.cad_AlunosTableAdapter.Fill(this.consultoriaDataSet.cad_Alunos);
            //  mesasBindingSource.MoveLast();

            //aparece a mensagem quando der certo
            MessageBox.Show("Aluno cadastrado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
             txtAltura.Clear();
            txtCel.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtPeso.Clear();
            mskCPF.Clear();
            mskRG.Clear();

            //chamar um novo registro
            cadAlunosBindingSource.AddNew();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
