using System;
using Enums;
using tabuleiro;

namespace xadrez
{
    public class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "H";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            int[,] direcoes = {
        {-1, -2}, {-2, -1}, {-2, +1}, {-1, +2},
        {+1, +2}, {+2, +1}, {+2, -1}, {+1, -2}
    };

            for (int i = 0; i < direcoes.GetLength(0); i++)
            {
                int linha = Posicao.Linha + direcoes[i, 0];
                int coluna = Posicao.Coluna + direcoes[i, 1];
                Posicao pos = new Posicao(linha, coluna);

                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[linha, coluna] = true;
                }
            }

            return mat;
        }

    }
}

