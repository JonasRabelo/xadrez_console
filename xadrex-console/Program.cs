using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez_console { 
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(2, 3);

            Console.WriteLine("posição: " + P);
        }
    }
}
