﻿using System;
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
    public partial class corrida2 : Form
    {
        string motoboy;
        string motoboyNome;

        public corrida2(string motoboy, string motoboyNome)
        {
            this.motoboy = motoboy;
            this.motoboyNome = motoboyNome;
            InitializeComponent();
            //Corrida corrida = new Corrida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //id, motoboy, cliente, destino, localizacao, pagamento, valor, status;
            classCorrida corrida = new classCorrida();

            cliente cc = new cliente();
            cc = cc.select(Session.Nome, Session.Senha);

            corrida.Motoboy = motoboy;
            corrida.Cliente = cc.Usuario;
            corrida.Destino = textBox1.Text;
            corrida.Localizacao = textBox2.Text;
            corrida.Pagamento = comboBox1.Text;
            corrida.Valor = "A combinar";
            corrida.Status = "Aguardando";

            corrida.cadastrar(corrida);

            Principal b = new Principal();
            b.Show();
            this.Close();
        }

        private void corrida2_Load(object sender, EventArgs e)
        {
            labelMotoboy.Text = "" + motoboyNome;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal v = new Principal();
            v.Show();
            this.Close();
        }
    }
}
