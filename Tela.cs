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
                for (int j = 0; j < tab.Colunas; j++)
                {
                    var p = tab.Peca(i, j);
                    if(p != null)
                    {
                        Console.Write(p);
                    } else
                    {
                        Console.Write("_");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
