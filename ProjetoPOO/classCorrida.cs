using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    class classCorrida
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string serSQL;

        // motoboy = cnh
        // email = cliente
        private string id, motoboy, cliente, destino, localizacao, pagamento, valor, status;

        public string Id { get => id; set => id = value; }
        public string Motoboy { get => motoboy; set => motoboy = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Status { get => status; set => status = value; }

        public bool cadastrar(classCorrida objCorrida)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "INSERT INTO corrida (motoboy, cliente, destino, localizacao, pagamento, valor, status) VALUES (@motoboy, @cliente, @destino, @localizacao, @pagamento, @valor, @status)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@motoboy", objCorrida.Motoboy);
                comando.Parameters.AddWithValue("@cliente", objCorrida.Cliente);
                comando.Parameters.AddWithValue("@destino", objCorrida.Destino);   
                comando.Parameters.AddWithValue("@localizacao", objCorrida.Localizacao);
                comando.Parameters.AddWithValue("@pagamento", objCorrida.Pagamento);
                comando.Parameters.AddWithValue("@valor", objCorrida.Valor);
                comando.Parameters.AddWithValue("@status", objCorrida.Status);

                conexao.Open();

                comando.ExecuteNonQuery();

                conexao.Close();
                conexao = null;
                comando = null;

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
          
        }

        public List<classCorrida> select(string cnh)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;
            string serSQL;

            List<classCorrida> corris = new List<classCorrida>();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "SELECT * FROM corrida WHERE motoboy = @cnh";
                
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@cnh", cnh);
                conexao.Open();

                dr = comando.ExecuteReader();
               

                while (dr.Read())
                {
                    classCorrida corri = new classCorrida();

                    corri.Id = dr["id"] + "";
                    corri.Motoboy = dr["motoboy"] + "";
                    corri.Cliente = dr["cliente"] + "";
                    corri.Destino = dr["destino"] + "";
                    corri.Localizacao = dr["localizacao"] + "";
                    corri.Pagamento = dr["pagamento"] + "";
                    corri.Valor = dr["valor"] + "";
                    corri.Status = dr["status"] + "";

                    corris.Add(corri);
              
                }
            }
            catch (Exception ex)
            {
                return corris;
            }

            return corris;
        }

        public classCorrida selectID(string id)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;
            string serSQL;

           

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "SELECT * FROM corrida WHERE id = @id";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();

                dr = comando.ExecuteReader();


                while (dr.Read())
                {
                    classCorrida corri = new classCorrida();

                    corri.Id = dr["id"] + "";
                    corri.Motoboy = dr["motoboy"] + "";
                    corri.Cliente = dr["cliente"] + "";
                    corri.Destino = dr["destino"] + "";
                    corri.Localizacao = dr["localizacao"] + "";
                    corri.Pagamento = dr["pagamento"] + "";
                    corri.Valor = dr["valor"] + "";
                    corri.Status = dr["status"] + "";

                    return corri;

                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        public classCorrida selectCliente(string emailCliente)
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataAdapter da;
            MySqlDataReader dr;
            string serSQL;

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "SELECT * FROM corrida WHERE cliente = @emailCliente";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@emailCliente", emailCliente);
                conexao.Open();

                dr = comando.ExecuteReader();


                while (dr.Read())
                {
                    classCorrida corri = new classCorrida();

                    corri.Id = dr["id"] + "";
                    corri.Motoboy = dr["motoboy"] + "";
                    corri.Cliente = dr["cliente"] + "";
                    corri.Destino = dr["destino"] + "";
                    corri.Localizacao = dr["localizacao"] + "";
                    corri.Pagamento = dr["pagamento"] + "";
                    corri.Valor = dr["valor"] + "";
                    corri.Status = dr["status"] + "";

                    return corri;

                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }

        public bool statusUpdate(string id, string status, string valor)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "UPDATE corrida SET status = @status, valor = @valor WHERE id = @id";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@status", status);
                comando.Parameters.AddWithValue("@valor", valor);

                conexao.Open();

                comando.ExecuteNonQuery();
                conexao.Close();

                conexao = null;
                comando = null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
           
        }

        public bool deleteID(string id)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=poo;Uid=root;Pwd=;");

                string strSQL = "DELETE FROM corrida WHERE id = @id";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();

                comando.ExecuteNonQuery();
                conexao.Close();
                conexao = null;
                comando = null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
           
        }


    }
}
