using System;
using contaBancaria;

class Program
{
        static void Main(string[] args)
        {
        // Cria uma nova conta
        Conta conta = new Conta();
        int opcao = 0;

        Console.WriteLine("Bem Vindo ao Lab 365 Bank \n");
        // Pede o número da conta
        Console.WriteLine("Informe o número da conta:");
        conta.NumeroConta = int.Parse(Console.ReadLine());

        // Pede o nome do titular
        Console.WriteLine("Informe o nome do titular:");
        conta.NomeTitular = Console.ReadLine();

        // Pede o tipo de conta
        Console.WriteLine("Informe o tipo de conta (0 - Corrente, 1 - Poupança):");
        int tipo = int.Parse(Console.ReadLine());

        // Define o tipo de conta do usuário
        if (tipo == 0)
        {
            conta.Tipo = TipoConta.CORRENTE;
        }
        else
        {
            conta.Tipo = TipoConta.POUPANCA;
        }
        // Loop para realizar operações na conta
        while (opcao != 4)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Consultar saldo");
            Console.WriteLine("4 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o valor do depósito:");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case 2:
                    Console.WriteLine("Informe o valor do saque:");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 3:
                    conta.ConsultarSaldo();
                    break;
                case 4:
                    Console.WriteLine("Obrigado por usar Lab 365 Bank");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}