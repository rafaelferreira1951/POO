using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPOO
{
    
    class motoboy
    {
       

        private string
            nome,
            usuario,
            senha,
            rg,
            cnh,
            email,
            telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }

       
        public List<motoboy> Listar()
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;
            string serSQL;

            List<motoboy> lista = new List<motoboy>();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "SELECT * FROM mototaxi";

                comando = new MySqlCommand(strSQL, conexao);


                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    // rg usuario senha nome cnh email telefone celular
                    motoboy mot = new motoboy();
                    mot.rg = dr["rg"] + "";
                    mot.Usuario = dr["usuario"] + "";
                    mot.Senha = dr["senha"] + "";
                    mot.Nome = dr["nome"] + "";
                    mot.Cnh = dr["cnh"] + "";
                    mot.Email = dr["email"] + "";
                    mot.Telefone = dr["telefone"] + "";
                    lista.Add(mot);
                    mot = null;
                }

                conexao.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
            
           
        }

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

                string strSQL = "SELECT * FROM mototaxi WHERE usuario = @nome AND senha = @senha";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);
                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    Session.Logar(nome, senha, "motoboy");
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
