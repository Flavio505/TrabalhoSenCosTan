using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo
{
    public class  Validacao : absPropriedades
    {
        public Validacao(string numero) : base (numero)

        {
            this.numero = numero;
            Executar();

        }

        private void Executar()
        {
            try
            {
                n1 = Convert.ToDouble(numero);
                Resposta = "numero correto";

            }
            catch (Exception)
            {

                Resposta = "numero incorreto";
            }  
            

        }
    }
}
