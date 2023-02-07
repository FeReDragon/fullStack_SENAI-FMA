Console.WriteLine("\nDigite 10 números inteiros no console:\n");
int[] numeros = new int[10];
int[] posicoes = new int[10];

// Laço para obtenção de 10 números inteiros inseridos pelo usuário
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o " + (i + 1) + "° número:");
    string? input = Console.ReadLine();
    // Tratamento de erros para entrada de números inválidos
    if (!int.TryParse(input, out int numero))
    {
        Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro.");
        i--;
        continue;
    }
    // Verifica se o número já foi inserido
    if (Array.IndexOf(numeros, numero) >= 0)
    {
        Console.WriteLine("O número já foi inserido! Por favor, digite outro número.");
        i--;
        continue;
    }
    numeros[i] = numero;
    posicoes[i] = i + 1;
}
Console.WriteLine("Números primos e suas posições:");
// Laço para verificar quais números inseridos são primos
for (int i = 0; i < 10; i++)
{
    if (primos(numeros[i]))
    {
        Console.WriteLine("O número {0} é primo, e está na posição {1}.", numeros[i], posicoes[i]);
    }
}
Console.ReadLine();
// Função para verificar se um número é primo
static bool primos (int n)
{
if (n <= 1) // Se o número for menor ou igual a 1, retorna false
{
    return false;
}
// Laço para verificar se há algum número entre 2 e n-1 que seja divisor de n
for (int i = 2; i < n; i++)
{
    if (n % i == 0) // Se n é divisível por i, retorna false
    {
        return false;
    }
}
return true; // Se não houver nenhum número entre 2 e n-1 que seja divisor de n, retorna true (n é primo)
}

