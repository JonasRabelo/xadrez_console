using System;
using System.Collections.Generic;
using tabuleiro;
using xadrex_console;

namespace xadrez_console { 
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
            Console.WriteLine();


        }
    }
}
