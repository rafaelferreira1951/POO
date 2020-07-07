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

        motoboy mot = new motoboy();
        List<motoboy> motoboys;

        private MySqlConnection connection;
        //public List<string> motoboys = new List<string>();
        public Corrida()
        {
            InitializeComponent();
            motoboys = mot.Listar();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            motoboy boy = new motoboy();
            boy = motoboys[listBox1.SelectedIndex];
         
            corrida2 corrida2 = new corrida2(boy.Cnh, boy.Nome);
            corrida2.ShowDialog();

          

            motoboy mot = new motoboy();
        

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
      
        }

        private void Corrida_Load(object sender, EventArgs e)
        {

            foreach (var item in motoboys)
            {
                listBox1.Items.Add(item.Nome);
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal b = new Principal();
            b.Show();
            this.Hide();
        }
    }
   }
