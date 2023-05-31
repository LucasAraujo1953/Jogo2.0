using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int li;
            int ls;
            int oculto;
            int palpite;
            int numJogadores;

            Console.WriteLine("Digite a quantidade de jogadores: ");
            numJogadores = int.Parse(Console.ReadLine());

            string[] nomesJogadores = new string[numJogadores];

            for (int i = 0; i < numJogadores; i++)
            {
                Console.WriteLine("Digite o nome do jogador {0}: ", i + 1);
                nomesJogadores[i] = Console.ReadLine();
            }

            Random random = new Random();
            oculto = random.Next(1, 101);

            Console.Clear();
            // Início do jogo
            int jogador = 0;
            li = 1;
            ls = 100;

            do
            {
                jogador = (jogador + 1) % numJogadores;

                do
                {
                    Console.WriteLine("{0}, digite um número entre {1} e {2}: ", nomesJogadores[jogador], li, ls);
                    palpite = int.Parse(Console.ReadLine());
                }
                while (palpite <= li || palpite >= ls);

                if (palpite == oculto)
                {
                    Console.WriteLine("Parabéns, {0}! Você perdeu!!.", nomesJogadores[jogador]);
                }
                else
                {
                    if (palpite < oculto)
                        li = palpite;
                    else
                        ls = palpite;
                }

            } while (palpite != oculto);

          
        }
    }
}
