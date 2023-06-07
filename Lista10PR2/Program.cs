using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Ex1()
        {
            Console.WriteLine("Ex1");
            {
                int N;

                do
                {
                    Console.WriteLine("Digite o tamanho do vetor:");
                    N = int.Parse(Console.ReadLine());

                    if (N <= 0)
                    {
                        Console.WriteLine("O tamanho do vetor deve ser maior que zero. Tente novamente.");
                    }
                } while (N <= 0);

                float[] numeros = new float[N];

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Digite o número {0}:", i + 1);
                    numeros[i] = float.Parse(Console.ReadLine());
                }

                float menor = numeros[0];
                float maior = numeros[0];
                float soma = numeros[0];

                for (int i = 1; i < N; i++)
                {
                    if (numeros[i] < menor)
                        menor = numeros[i];

                    if (numeros[i] > maior)
                        maior = numeros[i];

                    soma += numeros[i];
                }

                float media = soma / N;

                Console.WriteLine("Menor número: {0}", menor);
                Console.WriteLine("Maior número: {0}", maior);
                Console.WriteLine("Média aritmética: {0}", media);

                Console.WriteLine("Pressione Enter para executar novamente ou digite 'S' para sair.");
            } while (Console.ReadLine().ToUpper() != "S") ;
        }
        public static void Ex2()
        {
            Console.WriteLine("Ex2");
            {
                int N;

                do
                {
                    Console.WriteLine("Digite o tamanho do vetor:");
                    N = int.Parse(Console.ReadLine());

                    if (N <= 0)
                    {
                        Console.WriteLine("O tamanho do vetor deve ser maior que zero. Tente novamente.");
                    }
                } while (N <= 0);

                float[] numeros = new float[N];
                float soma = 0;

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Digite o número {0}:", i + 1);
                    numeros[i] = float.Parse(Console.ReadLine());
                    soma += numeros[i];
                }

                float media = soma / N;

                Console.WriteLine("Números maiores ou iguais à média:");

                for (int i = 0; i < N; i++)
                {
                    if (numeros[i] >= media)
                        Console.WriteLine(numeros[i]);
                }

                Console.WriteLine("Pressione Enter para executar novamente ou digite 'S' para sair.");
            } while (Console.ReadLine().ToUpper() != "S") ;
        }
        public static void Ex3()
        {
            Console.WriteLine("Ex3");
            {
                int N;

                do
                {
                    Console.WriteLine("Digite o tamanho do vetor:");
                    N = int.Parse(Console.ReadLine());

                    if (N <= 0)
                    {
                        Console.WriteLine("O tamanho do vetor deve ser maior que zero. Tente novamente.");
                    }
                } while (N <= 0);

                float[] numeros = new float[N];
                float soma = 0;
                Random random = new Random();

                for (int i = 0; i < N; i++)
                {
                    numeros[i] = random.Next(100); // Gera números aleatórios entre 0 e 99
                    soma += numeros[i];
                }

                float media = soma / N;

                Console.WriteLine("Números maiores ou iguais à média:");

                for (int i = 0; i < N; i++)
                {
                    if (numeros[i] >= media)
                        Console.WriteLine(numeros[i]);
                }

                Console.WriteLine("Pressione Enter para executar novamente ou digite 'S' para sair.");
            } while (Console.ReadLine().ToUpper() != "S") ;
        }
        public static void Ex4()
        {
            Console.WriteLine("Ex4");
            {
                int N;

                do
                {
                    Console.WriteLine("Digite a quantidade de nomes:");
                    N = int.Parse(Console.ReadLine());

                    if (N <= 0)
                    {
                        Console.WriteLine("A quantidade de nomes deve ser maior que zero. Tente novamente.");
                    }
                } while (N <= 0);

                List<string> nomes = new List<string>();

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Digite o nome {0}:", i + 1);
                    nomes.Add(Console.ReadLine());
                }

                Console.WriteLine("Nomes (do último para o primeiro):");

                for (int i = N - 1; i >= 0; i--)
                {
                    Console.WriteLine(nomes[i]);
                }

                Console.WriteLine("Pressione Enter para executar novamente ou digite 'S' para sair.");
            } while (Console.ReadLine().ToUpper() != "S") ;
        }
        public static void Ex5()
        {
            {
                do
                {
                    Console.WriteLine("Digite o tamanho do vetor:");
                    int N = int.Parse(Console.ReadLine());

                    if (N <= 0)
                    {
                        Console.WriteLine("O tamanho do vetor deve ser maior que zero. Tente novamente.");
                        continue;
                    }

                    int[] vetor = new int[N];
                    Random random = new Random();
                    int pares = 0;
                    int impares = 0;

                    for (int i = 0; i < N; i++)
                    {
                        vetor[i] = random.Next(100); // Gera números aleatórios entre 0 e 99

                        if (vetor[i] % 2 == 0)
                            pares++;
                        else
                            impares++;
                    }

                    Console.WriteLine("Quantidade de números pares: {0}", pares);
                    Console.WriteLine("Quantidade de números ímpares: {0}", impares);

                    Console.WriteLine("Pressione Enter para executar novamente ou digite 'S' para sair.");
                } while (Console.ReadLine().ToUpper() != "S");
            }
        }

            static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("=============MENU=============");
                Console.WriteLine("Para executar ex 1 - digite 1");
                Console.WriteLine("Para executar ex 2 - digite 2");
                Console.WriteLine("Para executar ex 3 - digite 3");
                Console.WriteLine("Para executar ex 4 - digite 4");
                Console.WriteLine("Para executar ex 4 - digite 5");
                Console.WriteLine("==============================");

                opcao = int.Parse(Console.ReadLine()); //Lê a opção escolhida
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Thanks for using my system!");
                        break;

                    case 1:
                        Ex1();
                        break;

                    case 2:
                        Ex2();
                        break;

                    case 3:
                        Ex3();
                        break;

                    case 4:
                        Ex4();
                        break;
                    
                    case 5:
                        Ex5();
                        break;
                }

            } while (opcao != 0);
        }
        
    }
}
