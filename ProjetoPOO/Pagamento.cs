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
    public partial class Pagamento : Form
    {
        private MySqlConnection connection;
        public Pagamento()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            String numCartao = txtNumCartao.Text;
            String codSeguranca = txtCodSeguranca.Text;
            String mesVenc = txtMesVenc.Text;
            String anoVenc = txtAnoVenc.Text;
            String nomeTitular = txtNomeTitular.Text;
            String cpf = txtCPF.Text;
            String nascTitular = txtNascTitular.Text;

            if (numCartao == "" || codSeguranca == "" || mesVenc == "" || anoVenc == "" || nomeTitular == "" || cpf == "" || nascTitular == "")
            {
                MessageBox.Show("Por favor preencha todos os Campos!");
            }

            else
            {
                MessageBox.Show("Cartão Cadastrado");
                connection = Conexao.GetConnection();
                connection.Open();
                MySqlCommand inserir = new MySqlCommand("INSERT INTO usuario (numCartao, codSeguranca, mesVenc, anoVenc, nomeTitular, cpf, nascTitular) VALUES (@NumCar, @Codsegu, @MesVenc, @AnoVenc, @NomeTitu, @cpf, @NascTitu)", connection);
                inserir.Parameters.AddWithValue("@@NumCar", numCartao);
                inserir.Parameters.AddWithValue("@Codsegu", codSeguranca);
                inserir.Parameters.AddWithValue("@MesVenc", mesVenc);
                inserir.Parameters.AddWithValue("@AnoVenc", anoVenc);
                inserir.Parameters.AddWithValue("@NomeTitu", nomeTitular);
                inserir.Parameters.AddWithValue("@cpf", cpf);
                inserir.Parameters.AddWithValue("@NascTitu", nascTitular);
                connection.Clone();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
