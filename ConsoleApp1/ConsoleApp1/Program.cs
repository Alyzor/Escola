using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pede exercicio a ser executado
            Console.WriteLine("Escolha o seu exercício");
            Console.WriteLine("");
            Console.WriteLine("Exercício 01 -> 1");
            Console.WriteLine("Exercício 02 -> 2");
            Console.WriteLine("Exercício 03 -> 3");
            Console.WriteLine("Exercício 04 -> 4");
            Console.WriteLine("Exercício 05 -> 5");
            Console.WriteLine("Exercício 06 -> 6");
            Console.WriteLine("Exercício 07 -> 7");
            Console.WriteLine("Exercício 08 -> 8");
            Console.WriteLine("");

            Console.Write("Escolha: ");

            string numExercicio = Console.ReadLine();

            Console.WriteLine(" ");

            if (int.TryParse(numExercicio, out int numero)) //verifica se o utilizador escolheu um número, caso contrário, retorna que o input estava incorreto
            {
                Console.WriteLine("Sim");
                

            }
            else
            {
                switch (numero) 
                {
                    case 1:
                        {
                            int compr, alt, area;
                            Console.WriteLine("Insira o comprimento do retângulo: ");
                            compr = int.Parse(Console.ReadLine()); //transforma o valor introduzido em tipo int
                            Console.WriteLine("Insira a altura do retângulo: ");
                            alt = int.Parse(Console.ReadLine()); //transforma o valor introduzido em tipo int

                            area = compr * alt; //multiplica o comprimento pela altura para calcular a área

                            Console.WriteLine("Área: " + area);

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Exercício Inexistente!");
                            break;
                        }
                }
            }

            Console.Read();
        }
    }
}
