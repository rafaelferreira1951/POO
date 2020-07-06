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
    }
}
