using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(Posicao p)
        {
            return Pecas[p.Linha, p.Coluna];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public void PosicionarPeca(Peca p, Posicao pos)
        {
            ValidarPosicao(pos);
            ExistePeca(pos);
            Pecas[pos.Linha, pos.Coluna] = p;
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        public bool PosicaoValida(Posicao pos)
        {
            return (pos.Linha > -1 
                && pos.Linha < Linhas 
                && pos.Coluna > -1 
                && pos.Coluna < Colunas);
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida! [" + pos.ToString() + "]");
            }
        }
    }
}
