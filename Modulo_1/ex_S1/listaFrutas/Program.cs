// Cria uma nova lista de frutas vazia
List<string> listaFruta = new List<string>();

// Pergunta ao usuário para inserir até 15 frutas, exibindo a mensagem na tela
Console.WriteLine("Insira até 15 frutas (digite 'ok' quando terminar):");

// Repete enquanto o número de frutas na lista for menor que 15
while (listaFruta.Count < 15)
{
    // Lê a próxima fruta do usuário
    string fruta = Console.ReadLine().Trim();

    // Verifica se o usuário digitou "ok" e para o loop se sim
    if (fruta == "ok")
    {
        break;
    }
    // Verifica se a fruta inserida pelo usuário é uma string válida
    if (!string.IsNullOrEmpty(fruta))
    {
        // Verifica se a fruta inserida pelo usuário já está na lista
        if (!listaFruta.Contains(fruta))
        {
            // Adiciona a fruta lida à lista de frutas
            listaFruta.Add(fruta);
        }
        else
        {
            Console.WriteLine("A fruta '" + fruta + "' já está na lista.");
        }
    }
}
// Verifica se a lista de frutas não está vazia antes de ordená-la
if (listaFruta.Count > 0)
{
    // Ordena a lista de frutas em ordem alfabética
    listaFruta.Sort();
}
// Verifica se a lista de frutas não está vazia antes de exibir a mensagem
if (listaFruta.Count > 0)
{
    // Exibe mensagem na tela
    Console.WriteLine("Sua Lista de Frutas organizada:");

    // Percorre cada fruta na lista organizada e exibe uma por uma na tela
    foreach (string fruta in listaFruta)
    {
        Console.WriteLine(fruta);
    }
}
else
{
    Console.WriteLine("Não há frutas na lista para exibir.");
}
