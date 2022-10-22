using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
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
                            double bruto, segSocial, irs, liquido;

                            Console.WriteLine("Introduza o seu salário bruto: ");
                            bruto = double.Parse(Console.ReadLine());

                            segSocial = bruto * 0.20;

                            if (bruto < 500)
                            {
                                irs = 0;
                            }
                            else if (bruto >= 500 && bruto <= 1000)
                            {
                                irs = bruto * 0.12;
                            }
                            else if (bruto >= 1000 && bruto <= 1500)
                            {
                                irs = bruto * 0.15;
                            }
                            else
                            {
                                irs = bruto * 0.18;
                            }

                            liquido = bruto - segSocial - irs;

                            Console.WriteLine("Salário Líquido: " + liquido);

                            break;
                        }
                    case 3:
                        {
                            long num, fatorial = 1;

                            Console.WriteLine("Introduza um número: ");
                            num = long.Parse(Console.ReadLine());

                            while(num>1)
                            {
                                fatorial = fatorial * num;
                                num--;
                            }

                            Console.WriteLine("Fatorial: " + fatorial);

                            break;
                        }
                    case 4:
                        {
                            int altura, comprimento;
                            double area;

                            Console.WriteLine("Introduza o comprimento do triângulo: ");
                            comprimento = int.Parse(Console.ReadLine());

                            Console.WriteLine("Introduza a altura do triângulo: ");
                            altura = int.Parse(Console.ReadLine());

                            area = (altura * comprimento) / 2D;

                            Console.WriteLine("Área: " + area);

                            break;
                        }
                    case 5:
                        {
                            double bruto, segSocial, irs = 0, liquido;
                            int escalao;

                            Console.WriteLine("Introduza o seu salário bruto: ");
                            bruto = double.Parse(Console.ReadLine());

                            segSocial = bruto * 0.20;

                            if (bruto < 500)
                            {
                                escalao = 1;
                            }
                            else if (bruto >= 500 && bruto <= 1000)
                            {
                                escalao = 2;
                            }
                            else if (bruto >= 1000 && bruto <= 1500)
                            {
                                escalao = 3;
                            }
                            else
                            {
                                escalao = 4;
                            }

                            switch (escalao)
                            {
                                case 1:
                                    irs = 0;
                                    break;

                                case 2:
                                    irs = bruto * 0.12;
                                    break;

                                case 3:
                                    irs = bruto * 0.15;
                                    break;

                                case 4:
                                    irs = bruto * 0.18;
                                    break;
                            }

                            liquido = bruto - segSocial - irs;

                            Console.WriteLine("Salário Líquido: " + liquido);

                            break;
                        }
                    case 6:
                        {
                            double bruto, segSocial, irs = 0, liquido;
                            int escalao;

                            Console.WriteLine("Introduza o seu salário bruto: ");
                            bruto = double.Parse(Console.ReadLine());

                            segSocial = bruto * 0.20;

                            if (bruto < 500)
                            {
                                escalao = 1;
                            }
                            else if (bruto >= 500 && bruto <= 1000)
                            {
                                escalao = 2;
                            }
                            else if (bruto >= 1000 && bruto <= 1500)
                            {
                                escalao = 3;
                            }
                            else
                            {
                                escalao = 4;
                            }

                            switch (escalao)
                            {
                                case 1:
                                    irs = 0;
                                    break;

                                case 2:
                                    irs = bruto * 0.12;
                                    break;

                                case 3:
                                    irs = bruto * 0.15;
                                    break;

                                case 4:
                                    irs = bruto * 0.18;
                                    break;
                            }

                            liquido = bruto - segSocial - irs;

                            Console.WriteLine("Salário Líquido: " + liquido);
                            Console.WriteLine("Desconto Segurança Social: " + segSocial);
                            Console.WriteLine("Desconto IRS: " + irs);

                            break;
                        }
                    case 7:
                        {
                            long num, fatorial = 1;

                            Console.WriteLine("Introduza um número: ");
                            num = long.Parse(Console.ReadLine());

                            for(int i = 1; i <= num; i ++)
                            {
                                fatorial = fatorial * i;
                            }

                            Console.WriteLine("Fatorial: " + fatorial);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Exercício Inexistente!");
                            break;
                        }
                }

            }
            else
            {
                Console.WriteLine("Exercício Inexistente!");
            }

            Console.Read();
        }
    }
}
