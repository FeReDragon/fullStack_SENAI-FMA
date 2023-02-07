
using System;
using System.Collections.Generic;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            List<float> medias = new List<float>();
            float media;

            Console.WriteLine("Cadastre o nome e média final de cinco alunos");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
                string nome = Console.ReadLine();
                nomes.Add(nome);

                do
                {
                    Console.Write("Digite a média final do aluno " + (i + 1) + ": ");
                    media = float.Parse(Console.ReadLine());
                    if (media < 0 || media > 10)
                    {
                        Console.WriteLine("Média fora dos parâmetros permitidos (min 0.0 e max 10.0)");
                    }
                } while (media < 0 || media > 10);

                medias.Add(media);
            }

            Console.WriteLine();
            Console.WriteLine("Relatório de alunos:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Aluno: " + nomes[i]);
                Console.WriteLine("Média final: " + medias[i]);
                if (medias[i] >= 6)
                {
                    Console.WriteLine("Resultado: APROVADO\n");
                }
                else
                {
                    Console.WriteLine("Resultado: REPROVADO\n");
                }
            }
        }
    }
}