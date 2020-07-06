using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    class cliente
    {
        private string
            usuario,
            endereco,
            email,
            senha,
            celular;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Celular { get => celular; set => celular = value; }

        public bool Login(string nome, string senha)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;
            string serSQL;

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "SELECT * FROM cliente WHERE usuario = @nome AND senha = @senha";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);
                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Session.Logar(nome, senha, "cliente");
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;

        }
    }
}
