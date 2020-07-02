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
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CRIATURA, ASSIM NÃO DA !!!!");
            }
            else
            {
                MessageBox.Show("CADASTRADO COM SUCESSO");
                txtNome.Clear();           
                txtNomeUser.Clear();
                txtSenha.Clear();
                txtRG.Clear();
                txtCNH.Clear();
                txtEmail.Clear();
                txtTel.Clear();
                txtCel.Clear();

                MySqlCommand inserir = new MySqlCommand("INSERT INTO cliente (email, login, senha, cnh, telefone, celular, nome) VALUES (@email, @User, @Pass, @cnh, @tel, @cel, @nome ", connection);
                inserir.Parameters.AddWithValue("@email", txtEmail);
                inserir.Parameters.AddWithValue("@User", txtNomeUser);
                inserir.Parameters.AddWithValue("@Pass", txtSenha);
                inserir.Parameters.AddWithValue("@cnh", txtCNH);
                inserir.Parameters.AddWithValue("@tel", txtTel);
                inserir.Parameters.AddWithValue("@cel", txtCel);
                inserir.Parameters.AddWithValue("@nome", txtNome);
                inserir.ExecuteNonQuery();
                principal.ShowDialog();
                connection.Close();
            }
        }
    }
}
