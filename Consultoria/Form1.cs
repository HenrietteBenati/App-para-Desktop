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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com o Login");
                txtLogin.Focus();
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entre com a senha !!");
                txtSenha.Focus();
            }
            else
            {
                if (txtLogin.Text=="BrunoCharles" && txtSenha.Text == "bruno123")
                {
                    MessageBox.Show("SEJA BEM VINDO BRUNO CHARLES !!");
                }
                else
                {
                    MessageBox.Show("Login ou Senha INVÁLIDOS");
                }

                Visible = false;
                this.Hide();
                Form2 novaform = new Form2();
                novaform.ShowDialog();
                Visible = true;

                AcceptButton = btnLogin;
            }
                
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }
    }
}
