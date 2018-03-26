namespace Tabuleiro
{
    class tabuleiro
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        public tabuleiro(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPos(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new ExceptionTabuleiro("Ja existe uma peca nessa posicao!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posValida(Posicao pos)
        {
            if(pos.linha<0 || pos.linha>=linha || pos.coluna<0 || pos.coluna >= coluna) { return false; } return true;
        }

        public void validarPos(Posicao pos)
        {
            if (!posValida(pos))
            {
                throw new ExceptionTabuleiro("Posicao Invalida!");
            }
        }
    }
}
