using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo
{
    public abstract class absPropriedades
    {
        public double n1;

        public double cosseno;
        public double seno;
        public double tangente;


        
        public string numero;
        public string Resposta { get; set; }
        public string Mensagem { get; set; }

        public absPropriedades(double n1)
        {
            this.n1 = n1;
        }

        public absPropriedades(string numero)
        {
            this.numero = numero;
        }

        private void Executar()
        {
           
        }

        //public string ToString()
        //{
            
        //}

    }
}
