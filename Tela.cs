using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    var p = tab.Peca(i, j);
                    if(p != null)
                    {
                        ImprimirPeca(p);
                    } else
                    {
                        Console.Write("_");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Write("  A B C D E F G H");
        }

        public static void ImprimirPeca(Peca peca)
        {
            var originalForegroundColor = Console.ForegroundColor;
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            } else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = originalForegroundColor;
            }
        }
    }
}
