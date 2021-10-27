using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo
{
    public class Controle : Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo.absPropriedades
    {
        absPropriedades calcular;

        public Controle(string numero) : base(numero)
        {
            
            Executar();

        }

        private void Executar()
        {
            calcular = new Validacao(this.numero);
            if(calcular.Resposta != "numero incorreto")

            {
                calcular = new Calcular(Convert.ToDouble(numero));
                this.seno = calcular.seno;
                this.cosseno = calcular.cosseno;
                this.tangente = calcular.tangente;
            }

        }

    }
}
