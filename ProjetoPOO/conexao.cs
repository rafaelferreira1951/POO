using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace ProjetoPOO
{
    class Conexao
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;user=root;database=poo;port=3306;password=";
            MySqlConnection connection = new MySqlConnection(connStr);
            return connection;
        }
    }
}
