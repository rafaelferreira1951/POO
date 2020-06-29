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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();



            String nomeUsuario = txtNomeUser.Text;
            String senha = txtSenha.Text;
            if (nomeUsuario == "")
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CRIATURA, ASSIM NÃO DA !!!!");
                txtNomeUser.Focus();
                return;
            }

            if (senha == "")
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CRIATURA, ASSIM NÃO DA !!!!");
                txtSenha.Focus();
                return;
            }

            else
            {
                MessageBox.Show("LOGADO COM SUCESSO");
                txtNomeUser.Clear();
                txtSenha.Clear();
            
                principal.ShowDialog();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
             
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CadastroMotoboy cadastromotoboy = new CadastroMotoboy();
            cadastromotoboy.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
