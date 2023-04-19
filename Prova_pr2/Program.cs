using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;

            Console.WriteLine("menu");
            Console.WriteLine("exercício 1");
            Console.WriteLine("exercício 2");
            Console.WriteLine("exercício 3");
            Console.WriteLine("exercício 4");
            Console.WriteLine("exercício 5");
            Console.WriteLine("exercício 6");

            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {

                case 1:
                    Console.Write("Digite um número inteiro: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        numero = -numero;
                    }

                    Console.WriteLine($"O valor absoluto do número é: {numero}");

                    break;

                case 2:


                    Console.Write("Digite um número inteiro: ");
                    int nu = int.Parse(Console.ReadLine());

                    if ((nu % 3 == 0) && (nu % 5 == 0))
                    {
                        Console.WriteLine("O número é múltiplo de 3 e 5");
                    }
                    else if ((nu % 4 == 0) && (nu % 7 == 0))
                    {
                        Console.WriteLine("O número é múltiplo de 4 e ");
                    }
                    else if (nu % 3 == 0)
                    {
                        Console.WriteLine("O número é divisível por 3");
                    }
                    else if (nu % 4 == 0)
                    {
                        Console.WriteLine("O número é divisível por 4");
                    }
                    else if (nu % 5 == 0)
                    {
                        Console.WriteLine("O número é divisível por 5");
                    }
                    else if (nu % 7 == 0)
                    {
                        Console.WriteLine("O número é divisível por 7");
                    }
                    else
                    {
                        Console.WriteLine("O número não é divisível por 3, 4, 5 ou 7");
                    }

                    Console.ReadKey();
                    break;

                case 3:

                    int num1, num2, num3;
                    Console.WriteLine("Digite três números inteiros:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    num3 = int.Parse(Console.ReadLine());

                    if (num1 > num2 && num1 > num3)
                    {
                        Console.WriteLine("O maior número é: " + num1);
                    }
                    else if (num2 > num3)
                    {
                        Console.WriteLine("O maior número é: " + num2);
                    }
                    else
                    {
                        Console.WriteLine("O maior número é: " + num3);
                    }
                    break;

                case 4:

                    Console.WriteLine("Digite um número de 1 a 7:");
                    int diaSemana = int.Parse(Console.ReadLine());

                    switch (diaSemana)
                    {

                        case 1:
                            Console.WriteLine("Disciplinas de domingo: Matemática e Física.");
                            break;
                        case 2:
                            Console.WriteLine("Disciplinas de segunda-feira: Química e Biologia.");
                            break;
                        case 3:
                            Console.WriteLine("Disciplinas de terça-feira: História e Geografia.");
                            break;
                        case 4:
                            Console.WriteLine("Disciplinas de quarta-feira: Inglês e Espanhol.");
                            break;
                        case 5:
                            Console.WriteLine("Disciplinas de quinta-feira: Filosofia e Sociologia.");
                            break;
                        case 6:
                            Console.WriteLine("Disciplinas de sexta-feira: Educação Física e Artes.");
                            break;
                        case 7:
                            Console.WriteLine("Fim de semana! Vamos relaxar e curtir com a família e amigos.");
                            break;
                        default:
                            Console.WriteLine("Número inválido! Por favor, digite um número de 1 a 7."); break;
                    }
                    break;

                case 5:

                    int num, max = int.MinValue, min = int.MaxValue;

                    do
                    {
                        Console.Write("Digite um número inteiro (0 para sair): ");
                        num = int.Parse(Console.ReadLine());

                        if (num != 0)
                        {
                            if (num > max)
                            {
                                max = num;
                            }

                            if (num < min)
                            {
                                min = num;
                            }
                        }
                    } while (num != 0);

                    Console.WriteLine("O maior número é " + max);
                    Console.WriteLine("O menor número é " + min);

                    Console.ReadKey();
                    break;


                case 6:

                    int number, sum = 0;

                    Console.Write("Digite um número inteiro: ");
                    number = int.Parse(Console.ReadLine());

                    for (int i = 1; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            sum += i;
                        }
                    }

                    if (sum == number)
                    {
                        Console.WriteLine($"{number} é um número perfeito.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} não é um número perfeito.");
                    }

                    Console.ReadKey();
                    break;

                case 7:
                    int numA, soma = 0, cont = 0;

                    do
                    {
                        Console.Write("Digite um número inteiro (ou zero para sair): ");
                        numA = int.Parse(Console.ReadLine());

                        if (numA!= 0 && numA % 2 == 0)
                        {
                            soma += numA;
                            cont++;
                        }

                    } while (numA != 0);

                    if (cont > 0)
                    {
                        double media = (double)soma / cont;
                        Console.WriteLine($"A média dos números pares é: {media}");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível calcular a média dos números pares.");
                    }

                    break;

















            }
        }

    }
}
    

