using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    class Session
    { 
        private static string nome;
        private static string senha; 
        private static bool logado = false;
        private static string tipo;


        public static string Nome { get => nome; set => nome = value; }
        public static string Senha { get => senha; set => senha = value; }
        public static bool Logado { get => logado; set => logado = value; }
        public static string Tipo { get => tipo; set => tipo = value; }

        public static bool Online
        {
            get
            {
                return logado;
            }
        }

       

        public static void Deslogar()
        {
            nome = null;    
            senha = null;    
            logado = false;
            tipo = "";
        }

        public static void Logar(string xnome, string xsenha, string xtipo)
        {
            nome = xnome;
            senha = xsenha;
            tipo = xtipo;
            logado = true;
        }

    }
}
