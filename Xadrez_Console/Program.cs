using System;
using Tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                tabuleiro tab = new tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch(ExceptionTabuleiro e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
