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
                try
                {
                    connection = Conexao.GetConnection();
                    connection.Open();
                    MySqlCommand select = new MySqlCommand("SELECT * FROM cliente WHERE usuario= '" + nomeUsuario + "'", connection);
                    select.ExecuteNonQuery();
                    principal.ShowDialog();
                    connection.Clone();
                }
                catch(Exception erro) 
                {
                    MessageBox.Show("Houve um erro ao logar!!"  + erro);
                }
             
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

        private void logarcomo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (logarcomo_SelectedIndexChanged == )
            //{

            //}
        }
    }
}
