using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class Pagamento : Form
    {
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
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CRIATURA, ASSIM NÃO DA !!!!");
            }

            else
            {
                MessageBox.Show("CARTÃO CADASTRADO COM SUCESSO");
                txtNumCartao.Clear();
                txtCodSeguranca.Clear();
                txtMesVenc.Clear();
                txtAnoVenc.Clear();
                txtNomeTitular.Clear();
                txtCPF.Clear();
                txtNascTitular.Clear();
            }
        }
    }
}
