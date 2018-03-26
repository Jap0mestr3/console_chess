using Tabuleiro;

namespace Xadrez
{
    class Rei: Peca 
    {
        public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linha, tab.coluna];

            Posicao pos = new Posicao(0, 0);
            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if(tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //NE
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direita
            pos.definirValores(posicao.linha, posicao.coluna+1);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //SE
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //SO
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //NO
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
