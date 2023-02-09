int n;
int x = 1, y = 0, z = 0;

// Solicita ao usuário a quantidade de números da sequência de Fibonacci que deseja exibir
Console.WriteLine("Insira a quantidade de números da sequência de Fibonacci que deseja exibir:");
string? number = Console.ReadLine();

// Verifica se a entrada é um número inteiro
if (int.TryParse(number, out n))
{
  // Cria a sequência de Fibonacci
  for (int i = 0; i < n; i++)
  {
    // Calcula o próximo número da sequência de Fibonacci
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
  }
}
else
{
  // Exibe uma mensagem de erro caso a entrada não seja um número inteiro
  Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
}

Console.ReadLine();
