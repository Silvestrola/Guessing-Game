using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicios_Gerais____
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tent = 3;
            string nome1;
            string nome2;

            int n1;
            int n2;


          
            Console.Write("Jogador 1 digite seu nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Jogador 2 digite seu nome: ");
            nome2 = Console.ReadLine();
            do
            {
                Console.WriteLine();
                Console.Write(nome1 + " escolha um número de 1 a 10: ");
                n1 = int.Parse(Console.ReadLine());
            } while (n1 < 1 || n1 > 10);
            Console.WriteLine();
            Console.Clear();
            do
            {
                do
                {
                    Console.Write(nome2 + " tente acertar o número escolhido pelo jogador 1. Escolha um número de 1 a 10: ");
                    n2 = int.Parse(Console.ReadLine());
                } while (n2 < 1 || n2 > 10);

                if (n1 == n2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("VOCÊ GANHOU!");
                    break;
                }
                else if (n1 != n2) ;
                {
                    tent--;
                    Console.WriteLine("VOCÊ ERROU!.\nTentativas restantes: " + tent );                    
                   
                    if (tent == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("VOCÊ PERDEU. ");
                        break;
                    }
                }
            } while (n1 != n2);

                   
            
        }
    }
    
}
