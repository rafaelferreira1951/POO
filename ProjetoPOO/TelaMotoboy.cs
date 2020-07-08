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
    public partial class TelaMotoboy : Form
    {
        public TelaMotoboy()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TelaMotoboy_Load(object sender, EventArgs e)
        {
           
            List<classCorrida> corridas;


            motoboy mot = new motoboy();

            panel1.Controls.Clear();
            int ii = 0;
            int yy = 5;

            string cnh = "";

            foreach (var item in mot.Listar())
            {
                if (item.Usuario.Equals(Session.Nome) && item.Senha.Equals(Session.Senha))
                {
                    cnh = item.Cnh;
                    break;
                }
            }


            classCorrida corri = new classCorrida();
            corridas = corri.select(cnh);

            foreach (var item in corridas)
            {
                PedidosCliente a = new PedidosCliente(item.Id);
                a.Location = new Point(6, (yy));
                yy = yy + a.Height + 5;
                panel1.Controls.Add(a);
                ii++;
            }
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login v = new Login();
            v.Show();
            this.Hide();
            Session.Deslogar();
        }
    }
}
