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
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string serSQL;

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

          

            motoboy mot = new motoboy();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
      
        }

        private void Corrida_Load(object sender, EventArgs e)
        {

            motoboy mot = new motoboy();
            List<motoboy> motoboys = mot.Listar();

            foreach (var item in motoboys)
            {
                listBox1.Items.Add(item.Nome);
            }
         
        }

    }
   }
