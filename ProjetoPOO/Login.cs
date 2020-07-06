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
    public partial class Login : Form
    {
        private MySqlConnection connection;
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String nome = txtNomeUser.Text;
            String senha = txtSenha.Text;
            String tipo = logarcomo.Text;

            if (nome == "" || senha == "" || tipo == "")
            {
                MessageBox.Show("Por favor preencha todos os Campos!");
                txtNomeUser.Focus();
            }
            else
            {
                if (tipo.Equals("Cliente"))
                {
                    Principal principal = new Principal();

                    cliente client = new cliente();

                    if (client.Login(nome, senha))
                    {

                        MessageBox.Show("CLIENTE: LOGADO COM SUCESSO");
                        Principal p = new Principal();
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao logar!!");
                    }
                }
                else if (tipo.Equals("MotoBoy"))
                {
                    TelaMotoboy tlmotoboy = new TelaMotoboy();

                    motoboy mot = new motoboy();

                    if (mot.Login(nome, senha))
                    {

                        MessageBox.Show("MOTOBOY: LOGADO COM SUCESSO");
                        //TelaMotoboy tlmotoboy = new TelaMotoboy();
                        tlmotoboy.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao logar!!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o tipo de conta");
                }
               

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
             
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CadastroMotoboy cadastromotoboy = new CadastroMotoboy();
            cadastromotoboy.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void logarcomo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (logarcomo_SelectedIndexChanged == )
            //{

            //}
        }
    }
}
