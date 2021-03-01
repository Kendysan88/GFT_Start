using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
/*     A classe Movel deverá acrescentar 11% imposto no valor final se
    quantidade for menor que 10 e 5% se quantidade for maior ou igual a
    10.*/
    class Movel : Produto
    {
        public Eletronico() : base()
        {

        }

        public double calcularValorFinal(double valor, int quantidade)
        {
            double total;
            total = valor * quantidade;
            return total + total * 0.1;
        }
    }
}
