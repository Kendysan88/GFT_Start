using System;
using System.Collections.Generic;
using System.Text;

namespace GFT_Start_1
{
    class ListaDeProdutos
    {
        private Produto[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ListaDeProdutos(int capacidadeInicial = 6)
        {
            _itens = new Produto[capacidadeInicial];
            _proximaPosicao = 0;

        }

        public void Adicionar(Produto item)
        {
            //VerificarCapacidade(_proximaPosicao + 1);


            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
    }
}
