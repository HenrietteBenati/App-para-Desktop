using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultoria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void agendaTelefonicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog1.Font;
            }
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.ForeColor = colorDialog1.Color;
            }
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        
   
       

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (perderAlteraçoes())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader
                        (openFileDialog1.FileName);
                    txtEditor.Text = sr.ReadToEnd();
                    sr.Dispose();
                    txtEditor.Modified = false;

                    this.Text = "Menu - " + openFileDialog1.FileName;
                }
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            if (perderAlteraçoes())
            {
                txtEditor.Clear();
                txtEditor.Modified = false;
                
                this.Text = "Menu-Novo";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
            txtEditor.BackColor = Color.White;
        }


        private bool perderAlteraçoes()
        {
            if (!txtEditor.Modified)
            {
                return true;
            }
            else
            {
                DialogResult op = MessageBox.Show("Deseja salvar as alterações ? ", "Bloco de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (op == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8 ))
                        {
                            sw.Write(txtEditor.Text);
                        }
                        this.Text = "Menu - " + saveFileDialog1.FileName;
                        //txtEditor.Clear();

                    }
                    return false;
                }
                else if (op == DialogResult.Cancel)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            perderAlteraçoes();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.Hide();
            FrmAlunos novaform = new FrmAlunos();
            novaform.ShowDialog();
            Visible = true;

        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void montarTreinoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grupoMuscularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
            this.Hide();
            frmGrupoMuscular novaform = new frmGrupoMuscular();
            novaform.ShowDialog();
            Visible = true;
        }

        private void dietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.Hide();
            frmDieta novaform = new frmDieta();
            novaform.ShowDialog();
            Visible = true;
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.Hide();
            frmControleFinanceiro novaform = new frmControleFinanceiro();
            novaform.ShowDialog();
            Visible = true;
        }

        private void alunosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
