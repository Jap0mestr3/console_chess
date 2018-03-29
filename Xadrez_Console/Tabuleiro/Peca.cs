namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public tabuleiro tab { get; protected set; }

        public Peca (tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }
        
        public bool existeMovimentoPossivel()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<tab.linha; i++)
            {
                for(int j=0; j < tab.coluna; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public abstract bool[,] movimentosPossiveis();

        public bool PodeMoverParaPosicao(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public void IncrementaMovimento()
        {
            qtdMovimentos++;
        }

        public void DecrementaMovimento()
        {
            qtdMovimentos--;
        }
    }
}
