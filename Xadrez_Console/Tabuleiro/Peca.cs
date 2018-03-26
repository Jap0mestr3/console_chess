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

        public abstract bool[,] movimentosPossiveis();

        public void IncrementaMovimento()
        {
            qtdMovimentos++;
        }
    }
}
