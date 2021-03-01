using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    A classe Eletrônico deverá acrescentar 15% de imposto no valor final.
    class Eletronico : Produto
    {
        public Eletronico(): base()
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
