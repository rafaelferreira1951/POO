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
    public partial class Corrida : Form
    {
        private MySqlConnection connection;
        //public List<string> motoboys = new List<string>();
        public Corrida()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            corrida2 corrida2 = new corrida2();
            corrida2.ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlCommand select = new MySqlCommand("SELECT nome, cnh, celular FROM mototaxi", connection);
                select.Parameters.Add("nome", ListViewItem);
                select.Parameters.Add("cnh", );
                select.Parameters.Add("celular", );
                select.Parameters.Clear();
                select.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception erro)
            {
               MessageBox.Show("Houve um Erro ao mostrar os Mototaxis disponiveis!!" + erro);
            }
            }
    }
}

//try
//            {
//                connection.Open();
//                MySqlCommand select = new MySqlCommand("SELECT nome, cnh, celular FROM mototaxi", connection);
//select.Parameters.Add("nome", txtListaMotoboys_SelectedIndexChanged);
//                select.Parameters.Add("cnh", txtListaMotoboys_SelectedIndexChanged);
//                select.Parameters.Add("celular", txtListaMotoboys_SelectedIndexChanged);
//                select.Parameters.Clear();
//                select.ExecuteNonQuery();
//                connection.Close();
//            }
//            catch(Exception erro)
//            {
//               MessageBox.Show("Houve um Erro ao mostrar os Mototaxis disponiveis!!" + erro);
//           }