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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AdicionarCartãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            pagamento.ShowDialog();
        }

        private void ChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corrida c = new Corrida();
            c.Show();
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
     
            classCorrida corri = new classCorrida().selectCliente(new cliente().select(Session.Nome, Session.Senha).Email);

            if (corri == null)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                nmotoboy.Text = new motoboy().selectCNH(corri.Motoboy).Nome;
                label5.Text = corri.Localizacao;
                label6.Text = corri.Destino;
                corrida.Text = corri.Valor;
                status.Text = corri.Status;
            }

          
        }
    }
}
