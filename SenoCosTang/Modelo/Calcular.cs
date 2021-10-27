using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo
{
    public class Calcular : Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo.absPropriedades
    {
        public Calcular(double n1) : base(n1) 
        {
            this.n1 = n1;
            Executar();
        }
        private void Executar()


        {
            this.seno = Math.Sin(n1);
            this.cosseno = Math.Cos(n1);
            this.tangente = Math.Tan(n1);


        }
    }
}
