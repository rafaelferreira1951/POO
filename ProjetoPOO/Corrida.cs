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
    public partial class Corrida : Form
    {

        public List<string> motoboys = new List<string>();
        public Corrida()
        {
            InitializeComponent();

            motoboys.Add("Rogerin");
            motoboys.Add("Amilton");
            motoboys.Add("Sr Jonson");

            txtListaMotoboys.DataSource = motoboys;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            corrida2 corrida2 = new corrida2();
            corrida2.ShowDialog();

        }
    }
}
