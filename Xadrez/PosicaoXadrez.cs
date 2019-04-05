using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace XadrezConsole.Xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }
        private static char[] colunas = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        public PosicaoXadrez(char coluna, int linha)
        {
            ValidarPosicao(coluna, linha);   
            Coluna = coluna;
            Linha = linha;
        }

        public PosicaoXadrez(Posicao pos)
        {
            Coluna = colunas[pos.Coluna];
            Linha = pos.Linha+1;
            ValidarPosicao(Coluna, Linha);
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public bool PosicaoValida(char coluna, int linha)
        {
            return (colunas.Contains(coluna) && linha > 0 && linha < 9);
        }

        public void ValidarPosicao(char coluna, int linha)
        {
            if (!PosicaoValida(coluna,linha))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
               
        public override string ToString()
        {
            return "" + Coluna.ToString().ToUpper() + Linha;
        }
    }
}
