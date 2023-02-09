
using System;
using System.Collections.Generic;

namespace MediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declara duas listas, uma para armazenar nomes e outra para armazenar médias.
            List<string> nomes = new List<string>();
            List<float> medias = new List<float>();
            // Variável para armazenar a média do aluno.
            float media;

            // Exibe a mensagem para o usuário informando que serão cadastrados o nome e a média final de 5 alunos.
            Console.WriteLine("Cadastre o nome e média final de cinco alunos");

            // Loop para percorrer os 5 alunos.
            for (int i = 0; i < 5; i++)
            {
                // Pede o nome do aluno.
                Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
                string nome = Console.ReadLine();
                nomes.Add(nome);

                  // Laço de repetição que continua enquanto a média for fora dos parâmetros permitidos (entre 0.0 e 10.0)
                do
                {
                    // Lê a média informada pelo usuário.
                    Console.Write("Digite a média final do aluno " + (i + 1) + ": ");

                     // Verifica se a média está fora dos parâmetros permitidos.
                    media = float.Parse(Console.ReadLine());
                    if (media < 0 || media > 10)
                    {
                        // Exibe mensagem informando que a média está fora dos parâmetros permitidos.
                        Console.WriteLine("Média fora dos parâmetros permitidos (min 0.0 e max 10.0)");
                    }
                } while (media < 0 || media > 10);

                // Adiciona a média do aluno na lista de médias.
                medias.Add(media);
            }

            Console.WriteLine();
            Console.WriteLine("Relatório de alunos:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Aluno: " + nomes[i]);
                // Exibe o relatório de alunos.
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