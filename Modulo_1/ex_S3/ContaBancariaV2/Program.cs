using System;

namespace contaBancariav2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria duas novas contas
            ContaBancaria conta = new ContaBancaria("Felipe", 001, 1000, TipoConta.CORRENTE);
            ContaBancaria conta1 = new ContaBancaria("João", 002, 2000, TipoConta.POUPANCA);
            int opcao = 0;

            Console.WriteLine("Conta criada com sucesso!\nNúmero da conta: " + conta.NumeroConta +
            "\nNúmero da agência: " + conta.NumeroAgencia + "\nNome do titular: "
            + conta.NomeTitular + "\nTipo de conta: " + conta.Tipo + "\nSaldo: R$ "
            + conta.Saldo);

            Console.WriteLine("\nConta criada com sucesso!\nNúmero da conta: " + conta1.NumeroConta +
            "\nNúmero da agência: " + conta1.NumeroAgencia + "\nNome do titular: "
            + conta1.NomeTitular + "\nTipo de conta: " + conta1.Tipo + "\nSaldo: R$ "
            + conta1.Saldo);


            while (opcao != 5)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Consultar saldo");
                Console.WriteLine("4 - Transferir");
                Console.WriteLine("5 - Sair");
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
                        Console.WriteLine("Informe o número da conta de destino:");
                        int numeroContaDestino = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor a ser transferido:");
                        double valorTransferencia = double.Parse(Console.ReadLine());
                        conta.Transferir(valorTransferencia, numeroContaDestino);
                        break;
                    case 5:
                        Console.WriteLine("Obrigado por usar Lab 365 Bank");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }
        }
    }
}