using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
using xadrex_console;

namespace xadrez_console { 
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 6));

            Tela.ImprimirTabuleiro(tab);
            Console.WriteLine();


        }
    }
}
