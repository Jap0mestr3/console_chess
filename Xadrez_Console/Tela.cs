using System;
using Tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void imprimirTabuleiro(tabuleiro tab)
        {
            for(int i = 0; i<tab.linha; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j<tab.coluna; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
