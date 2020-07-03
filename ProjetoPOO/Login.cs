using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoPOO
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            String nomeUsuario = txtNomeUser.Text;
            String senha = txtSenha.Text;
            if (nomeUsuario == "" || senha == "")
            {
                MessageBox.Show("Por favor preencha todos os Campos!");
                txtNomeUser.Focus();
                return;
            }
            else
            {
                MessageBox.Show("LOGADO COM SUCESSO");

                connection = Conexao.GetConnection();
                connection.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO usuario (usuario, senha) VALUES (@User,@Pass)", connection);
                inserir.Parameters.AddWithValue("@User", nomeUsuario);
                inserir.Parameters.AddWithValue("@Pass", senha);
                principal.ShowDialog();
                connection.Clone();
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
