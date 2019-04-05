using System;
using Tabuleiro;
using XadrezConsole.Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            //Brancas
            for (int i = 0; i < 8; i++) tabuleiro.PosicionarPeca(new Peao(tabuleiro, Cor.Branca), new Posicao(1,i));
            tabuleiro.PosicionarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(0, 0));
            tabuleiro.PosicionarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(0, 7));
            tabuleiro.PosicionarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(0, 1));
            tabuleiro.PosicionarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(0, 6));
            tabuleiro.PosicionarPeca(new Bispo(tabuleiro, Cor.Branca), new Posicao(0, 2));
            tabuleiro.PosicionarPeca(new Bispo(tabuleiro, Cor.Branca), new Posicao(0, 5));
            tabuleiro.PosicionarPeca(new Rainha(tabuleiro, Cor.Branca), new Posicao(0, 3));
            tabuleiro.PosicionarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(0, 4));

            //Pretas
            for (int i = 0; i < 8; i++) tabuleiro.PosicionarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(6, i));
            tabuleiro.PosicionarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 0));
            tabuleiro.PosicionarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 7));
            tabuleiro.PosicionarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(7, 1));
            tabuleiro.PosicionarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(7, 6));
            tabuleiro.PosicionarPeca(new Bispo(tabuleiro, Cor.Branca), new Posicao(7, 2));
            tabuleiro.PosicionarPeca(new Bispo(tabuleiro, Cor.Branca), new Posicao(7, 5));
            tabuleiro.PosicionarPeca(new Rainha(tabuleiro, Cor.Branca), new Posicao(7, 3));
            tabuleiro.PosicionarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(7, 4));

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadKey();
        }
    }
}
