using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoPOO
{
    public partial class Cadastro : Form
    {
        private MySqlConnection connection;

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

            
            Principal principal = new Principal();
            String endereco = txtEndereco.Text;
            String nomeUsuario = txtNomeUser.Text;
            String senha = txtSenha.Text;
            String email = txtEmail.Text;
            String cel = txtCel.Text;

            if (nomeUsuario == "" || senha == "" || email == "" || endereco == "")
            {
                MessageBox.Show("Por favor, Preencha os campos");
            }
            else
            {
                MessageBox.Show("Cadastrado com Sucesso");

                connection = Conexao.GetConnection();
                connection.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO cliente (email, usuario, senha, endereco, celular) VALUES (@email, @User, @Pass, @Ende, @cel) ", connection);
                inserir.Parameters.AddWithValue("@email", email);
                inserir.Parameters.AddWithValue("@User", nomeUsuario);
                inserir.Parameters.AddWithValue("@Pass", senha);
                inserir.Parameters.AddWithValue("@Ende", endereco);
                inserir.Parameters.AddWithValue("@cel", cel);
                inserir.ExecuteNonQuery();
                Session.Logar(nomeUsuario, senha, "Cliente");
                this.Hide();
                principal.ShowDialog();
                connection.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login blogin = new Login();
            blogin.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
