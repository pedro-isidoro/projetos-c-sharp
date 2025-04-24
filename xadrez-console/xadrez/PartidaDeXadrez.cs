using System;
using tabuleiro;
using Enums;
using xadrez;
using System.Collections.Generic;

namespace xadrez
{
	public class PartidaDeXadrez
	{
		public Tabuleiro Tab { get; private set; }
		public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;
        public bool Xeque { get; private set; }

		public PartidaDeXadrez()
		{
			Tab = new Tabuleiro(8, 8);
			Turno = 1;
			JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            ColocarPecas();
		}

		public Peca ExecutaMovimento(Posicao origem, Posicao destino)
		{
			Peca p = Tab.RetirarPeca(origem);
			p.IncrementarQtdMovimentos();
			Peca pecaCapaturada = Tab.RetirarPeca(destino);
			Tab.ColocarPeca(p, destino);
            if(pecaCapaturada != null)
            {
                Capturadas.Add(pecaCapaturada);
            }
            return pecaCapaturada;
		}

        public void DesfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca p = Tab.RetirarPeca(destino);
            p.DecrementarQtdMovimentos();
            if(pecaCapturada != null)
            {
                Tab.ColocarPeca(pecaCapturada, destino);
                Capturadas.Remove(pecaCapturada);
            }
            Tab.ColocarPeca(p, origem);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = ExecutaMovimento(origem, destino);
            if (EstaEmXeque(JogadorAtual))
            {
                DesfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }
            if (EstaEmXeque(Adversaria(JogadorAtual)))
            {
                Xeque = true;
            }
            else
            {
                Xeque = false;
            }

            if (testeXequemate(Adversaria(JogadorAtual)))
            {
                Terminada = true;
            }
            else
            {
                Turno++;
                MudaJogador();
            }
        }

        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if(Tab.Peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if(JogadorAtual != Tab.Peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.Peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> PecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach(Peca x in Capturadas)
            {
                if(x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
                return aux;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Pecas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
                aux.ExceptWith(PecasCapturadas(cor));
            }
                return aux;
        }

        private Cor Adversaria(Cor cor)
        {
            if(cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }

        private Peca Rei(Cor cor)
        {
            foreach(Peca x in PecasEmJogo(cor))
            {
                if(x is Rei)
                {
                    return x;
                }
            }
            return null;
        }

        public bool EstaEmXeque(Cor cor)
        {
            Peca R = Rei(cor);
            if(R == null)
            {
                throw new TabuleiroException($"Não tem rei da cor {cor} no tabuleiro!");
            }
            foreach(Peca x in PecasEmJogo(Adversaria(cor)))
            {
                bool[,] mat = x.MovimentosPossiveis();
                if (mat[R.Posicao.Linha, R.Posicao.Coluna])
                {
                    return true;
                }
            }
            return false;
        }

        public bool testeXequemate(Cor cor)
        {
            if (!EstaEmXeque(cor))
            {
                return false;
            }
            foreach(Peca x in PecasEmJogo(cor))
            {
                bool[,] mat = x.MovimentosPossiveis();
                for(int i=0; i<Tab.Linhas; i++)
                {
                    for(int j=0; j<Tab.Colunas; j++)
                    {
                        if (mat[i, j])
                        {
                            Posicao origem = x.Posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);
                            bool testeXeque = EstaEmXeque(cor);
                            DesfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tab.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            Pecas.Add(peca);
        }


        private void ColocarPecas()
		{
            ColocarNovaPeca('a', 8, new Torre(Tab, Cor.Preta));
            ColocarNovaPeca('b', 8, new Cavalo(Tab, Cor.Preta));
            ColocarNovaPeca('c', 8, new Bispo(Tab, Cor.Preta));
            ColocarNovaPeca('d', 8, new Rainha(Tab, Cor.Preta));
            ColocarNovaPeca('e', 8, new Rei(Tab, Cor.Preta));
            ColocarNovaPeca('f', 8, new Bispo(Tab, Cor.Preta));
            ColocarNovaPeca('g', 8, new Cavalo(Tab, Cor.Preta));
            ColocarNovaPeca('h', 8, new Torre(Tab, Cor.Preta));
            ColocarNovaPeca('a', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('b', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('c', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('d', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('e', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('f', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('g', 7, new Peao(Tab, Cor.Preta));
            ColocarNovaPeca('h', 7, new Peao(Tab, Cor.Preta));

            ColocarNovaPeca('a', 1, new Torre(Tab, Cor.Branca));
            ColocarNovaPeca('b', 1, new Cavalo(Tab, Cor.Branca));
            ColocarNovaPeca('c', 1, new Bispo(Tab, Cor.Branca));
            ColocarNovaPeca('d', 1, new Rei(Tab, Cor.Branca));
            ColocarNovaPeca('e', 1, new Rainha(Tab, Cor.Branca));
            ColocarNovaPeca('f', 1, new Bispo(Tab, Cor.Branca));
            ColocarNovaPeca('g', 1, new Cavalo(Tab, Cor.Branca));
            ColocarNovaPeca('h', 1, new Torre(Tab, Cor.Branca));
            ColocarNovaPeca('a', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('b', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('c', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('d', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('e', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('f', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('g', 2, new Peao(Tab, Cor.Branca));
            ColocarNovaPeca('h', 2, new Peao(Tab, Cor.Branca));

            //Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('a', 8).toPosicao());
            //Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('b', 8).toPosicao());
            //Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            //Tab.ColocarPeca(new Rainha(Tab, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());
            //Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            //Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('f', 8).toPosicao());
            //Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('g', 8).toPosicao());
            //Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('h', 8).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('a', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('b', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('f', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('g', 7).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('h', 7).toPosicao());

            //Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).toPosicao());
            //Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('b', 1).toPosicao());
            //Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            //Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());
            //Tab.ColocarPeca(new Rainha(Tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            //Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('f', 1).toPosicao());
            //Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('g', 1).toPosicao());
            //Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('a', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('b', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('f', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('g', 2).toPosicao());
            //Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('h', 2).toPosicao());

        }
    }
}

