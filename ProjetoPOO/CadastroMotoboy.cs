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
    public partial class CadastroMotoboy : Form
    {
        private MySqlConnection connection;
        public CadastroMotoboy()
        {
            InitializeComponent();
        }

        private void CadastroMotoboy_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login blogin = new Login();
            blogin.Show();
            this.Hide();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            String nome = txtNome.Text;
            String nomeUsuario = txtNomeUser.Text;
            String senha = txtSenha.Text;
            String rg = txtRG.Text;
            String cnh = txtCNH.Text;
            String email = txtEmail.Text;
            String tel = txtTel.Text;
            String cel = txtCel.Text;

            if (nome == "" || nomeUsuario == "" || senha == "" || rg == "" || cnh == "" || email == "" || tel == "" || cel == "")
            {
                MessageBox.Show("Por favor preencha todos os Campos!");
            }
            else
            {
                MessageBox.Show("Cadastrado Com Sucesso!");

                connection = Conexao.GetConnection();
                connection.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO motoboy (email, usuario, senha, rg, cnh, telefone, celular, nome) VALUES (@email, @User, @Pass, @rg, @cnh, @tel, @cel, @nome) ", connection);
                inserir.Parameters.AddWithValue("@email", email);
                inserir.Parameters.AddWithValue("@User", nomeUsuario);
                inserir.Parameters.AddWithValue("@Pass", senha);
                inserir.Parameters.AddWithValue("@rg", rg);
                inserir.Parameters.AddWithValue("@cnh", cnh);
                inserir.Parameters.AddWithValue("@tel", tel);
                inserir.Parameters.AddWithValue("@cel", cel);
                inserir.Parameters.AddWithValue("@nome", nome);
                inserir.ExecuteNonQuery();
                principal.ShowDialog();
                connection.Close();
            }
        }
    }
}
