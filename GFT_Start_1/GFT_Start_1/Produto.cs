using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    class Produto
    {
        private string nome;
        private double valor;
        private int quantidade;


        public string Nome { get; set; }

        public double Valor { get; set; }

        public int Quantidade { get; set; }


        public double calcularValorFinal(double valor, int quantidade)
        {
            double total;
            total = valor * quantidade;
            return total + total*0.1;
        }
        
    }
}
