using System;
using tabuleiro;
using Enums;

namespace tabuleiro
{
	public abstract class Peca
	{
		public Posicao Posicao { get; set; }

		public Cor Cor { get; set; }

		public int QtdMovimentos { get; protected set; }

		public Tabuleiro Tab { get; protected set; }

		public Peca(Tabuleiro tab, Cor cor)
		{
			Posicao = null;
			Tab = tab;
			Cor = cor;
			QtdMovimentos = 0;
		}

		public void IncrementarQtdMovimentos()
		{
			QtdMovimentos++;
		}

		public void DecrementarQtdMovimentos()
		{
			QtdMovimentos--;
		}

		public abstract bool[,] MovimentosPossiveis();

		public bool ExisteMovimentosPossiveis()
		{
			bool[,] mat = MovimentosPossiveis();
			for(int i=0; i<Tab.Linhas; i++)
			{
				for(int j=0; j<Tab.Colunas; j++)
				{
					if (mat[i, j])
					{
						return true;
					}
				}
			}
			return false;
		}

		public bool PodeMoverPara(Posicao pos)
		{
			return MovimentosPossiveis()[pos.Linha, pos.Coluna];
		}

        protected bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        protected bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != this.Cor;
        }

    }
}

