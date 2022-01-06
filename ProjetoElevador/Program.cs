using ProjetoElevador.Models;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
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
        }
    }
}
