using System;
using ProjetoElevador.Models;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Roda()
            {
                static int Run()
                {
                    int andares = Elevador.andares();
                    int capacidade = Elevador.capacidade();
                    int pessoas = Elevador.pessoas(capacidade);
                    Elevador.inicializar(0);
                    int andar_atual = 0;

                    Console.WriteLine(
                            "\n1 - Subir um andar\n" +
                            "2 - Descer um andar\n" +
                            "3 - Adicionar uma pessoa ao elevador\n" +
                            "4 - Remover uma pessoa do elevador\n" +
                            "5 - Parar elevador e sair\n");
                    int answer = int.Parse(Console.ReadLine());

                    while (answer != 5)
                    {
                        if (answer == 1)
                        {
                            andar_atual = Elevador.subir(andar_atual, andares);
                            Console.WriteLine($"Andar atual: {andar_atual}");
                            answer = Elevador.run(answer);
                        }
                        else if (answer == 2)
                        {
                            andar_atual = Elevador.descer(andar_atual, andares);
                            Console.WriteLine($"Andar atual: {andar_atual}");
                            answer = Elevador.run(answer);
                        }
                        else if (answer == 3)
                        {
                            pessoas = Elevador.entrar(pessoas, capacidade);
                            Console.WriteLine($"Pessoas no elevador: {pessoas}");
                            answer = Elevador.run(answer);
                        }
                        else if (answer == 4)
                        {
                            pessoas = Elevador.sair(pessoas);
                            Console.WriteLine($"Pessoas no elevador: {pessoas}");
                            answer = Elevador.run(answer);
                        }
                        else
                        {
                            Console.WriteLine("Selecione uma opção válida!");
                            answer = Elevador.run(answer);
                        }
                    }
                    Console.WriteLine("\nDeseja usar o elevador novamente?\n1 - Sim\n2 - Não\n");
                    var nov = Console.ReadLine().ToLower();
                    while (nov == "")
                    {
                        Console.WriteLine("Digite o número da opção que deseja!");
                        Console.WriteLine("Deseja usar o elevador novamente?\n 1 - Sim\n 2 - Não\n");
                        nov = Console.ReadLine().ToLower();
                    }
                    int response = int.Parse(nov);
                    return response;
                }
                int response = Run();

                while (response == 1)
                {
                    Elevador.inicializar(0);
                    response = Run();
                }
            }
            Roda();
        }
    }
}
