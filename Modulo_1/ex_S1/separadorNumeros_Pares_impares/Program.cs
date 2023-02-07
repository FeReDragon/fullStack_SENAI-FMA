
//Listas para armazenar os números pares e ímpares
List<int> pares = new List<int>();
List<int> impares = new List<int>();
int somaPares = 0;
int somaImpares = 0;

//Recebendo 10 números inteiros do usuário
Console.WriteLine("Informe 10 números inteiros: ");
for (int i = 0; i < 10; i++)
{
    int numero = int.Parse(Console.ReadLine());

    //Verificando se o número é par ou ímpar
    if (numero % 2 == 0)
    {
        //Adicionando os números pares na lista de pares
        pares.Add(numero);
        //Somando os números da lista de pares
        somaPares += numero;
    }
    else
    {
        //Adicionando os números ímpares na lista de ímpares
        impares.Add(numero);
        //Somando os números da lista de ímpares
        somaImpares += numero;
    }
}

//Ordenando os números de cada lista em ordem crescente
pares.Sort();
impares.Sort();

//Exibindo o resultado
Console.WriteLine("A lista de números pares possui {0} números e a soma deles é igual a {1}", pares.Count, somaPares);
Console.WriteLine("A lista de números ímpares possui {0} números e a soma deles é igual a {1}", impares.Count, somaImpares);
Console.ReadKey();
