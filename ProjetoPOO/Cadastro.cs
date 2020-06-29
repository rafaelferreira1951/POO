using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String nomeUsuario = txtNomeUser.Text;
            String senha = txtSenha.Text;
            String email = txtEmail.Text;

            if (nomeUsuario == "" || senha == "" || email =="")
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CRIATURA, ASSIM NÃO DA !!!!");
            }

            else
            {
                MessageBox.Show("CADASTRADO COM SUCESSO");
                txtNomeUser.Clear();
                txtSenha.Clear();
                txtEmail.Clear();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login blogin = new Login();
            blogin.Show();
            this.Hide();
        }
    }
}
