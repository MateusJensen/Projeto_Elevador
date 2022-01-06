using System;

namespace ProjetoElevador.Models
{
    internal class Elevador
    {
        /*Inicialização do elevador no terreo!*/
        public static void inicializar(int terreo)
        {
            int andar_atual = terreo;
            Console.WriteLine("\nElevador iniciado!");
        }

        /*Definição de Andares do prédio*/
        public static int andares()
        {
            Console.WriteLine("Insira a quantidade de andares do prédio: ");
            int andares = int.Parse(Console.ReadLine());
            return andares;
        }

        /*Definição da capacidade de pessoas dentro do elevador*/
        public static int capacidade()
        {
            Console.WriteLine("Insira a capacidade do elevador: ");
            int capacidade = int.Parse(Console.ReadLine());
            return capacidade;
        }

        /*Definição de pessoas que ja estão dentro do elevador*/
        public static int pessoas(int capacidade)
        {
            Console.WriteLine("Quantas pessoas estão no elevador?");
            int pessoas = int.Parse(Console.ReadLine());
            if (pessoas > capacidade)
            {
                while (pessoas > capacidade)
                {
                    Console.WriteLine("A quantidade de pessoas excede o limite de capacidade!");
                    Console.WriteLine("Quantas pessoas estão no elevador?");
                    pessoas = int.Parse(Console.ReadLine());
                }
            }
            return pessoas;
        }

        /*Função para adicionar uma pessoa ao elevador*/
        public static int entrar(int pessoas, int capacidade)
        {
            if (pessoas >= capacidade)
            {
                Console.WriteLine("Não é possivel entrar no elevador!");
                return pessoas;
            }
            else
            {
                return pessoas + 1;
            }
        }

        /*Função para retirar uma pessoa do elevador*/
        public static int sair(int pessoas)
        {
            if (pessoas == 0)
            {
                Console.WriteLine("Não há ninguem no elevador!");
                return pessoas;
            }
            else
            {
                return pessoas - 1;
            }
        }

        /*Função para subir um andar*/
        public static int subir(int andar_atual, int andares)
        {
            if (andar_atual == andares)
            {
                Console.WriteLine("Ñâo é possivel subir pois chegamos ao topo!");
                return andar_atual;
            }
            else
            {
                return andar_atual + 1;
            }
        }

        /*Função para descer um andar*/
        public static int descer(int andar_atual, int terreo)
        {
            if (andar_atual == 0)
            {
                Console.WriteLine("Não é possivel descer pois estamos no térreo!");
                return andar_atual;
            }
            else
            {
                return andar_atual - 1;
            }

        }
        
        /*Funcção para decisão da próxima ação do elevador*/
        public static int run(int answer)
        {
            Console.WriteLine(
                        "\n1 - Subir um andar\n" +
                        "2 - Descer um andar\n" +
                        "3 - Adicionar uma pessoa ao elevador\n" +
                        "4 - Remover uma pessoa do elevador\n" +
                        "5 - Parar elevador e sair\n");
            var x = Console.ReadLine();
            if(x == "")
            {
                answer = 0;
                return answer;
            }
            else
            {

                answer = int.Parse(x);
                return answer;
            }
        }
    }
}