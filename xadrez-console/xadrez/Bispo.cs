using System;
using Enums;
using tabuleiro;

namespace xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "B";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            int[,] direcoes = {
        {-1, -1}, {-1, +1},
        {+1, +1}, {+1, -1}
    };

            for (int i = 0; i < direcoes.GetLength(0); i++)
            {
                int dx = direcoes[i, 0];
                int dy = direcoes[i, 1];

                pos.DefinirValores(Posicao.Linha + dx, Posicao.Coluna + dy);

                while (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                        break;

                    pos.DefinirValores(pos.Linha + dx, pos.Coluna + dy);
                }
            }

            return mat;
        }
    }
}

