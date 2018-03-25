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
                for(int j = 0; j<tab.coluna; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                    Console.Write(tab.peca(i,j)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
