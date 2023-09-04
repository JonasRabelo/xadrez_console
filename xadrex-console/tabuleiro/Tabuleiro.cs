namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set;}
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linhas = linha;
            Colunas = coluna;
            pecas = new Peca[Linhas, Colunas];
        }
    }
}
