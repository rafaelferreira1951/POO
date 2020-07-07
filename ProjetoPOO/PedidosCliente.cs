using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class PedidosCliente : UserControl
    {
        classCorrida corri = new classCorrida();

        public PedidosCliente(string id)
        {
            InitializeComponent();
            this.corri = new classCorrida().selectID(id);
        }

        private void PedidosCliente_Load(object sender, EventArgs e)
        {
            txtcliente.Text = corri.Cliente;
            loc.Text = corri.Localizacao;
            dest.Text = corri.Destino;
            pag.Text = corri.Pagamento;
            textBox1.Text = corri.Valor;
        }

        private void loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            classCorrida c = new classCorrida();

            bool foi = false;
            
            foi = c.statusUpdate(corri.Id, "Confirmado", textBox1.Text);

            if (foi)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NO");
            }
           
        }

        private void Rejeitar_Click(object sender, EventArgs e)
        {
            classCorrida c = new classCorrida();

            bool foi = false;

            foi = c.statusUpdate(corri.Id, "Rejeitado", textBox1.Text);

            if (foi)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }
    }
}
