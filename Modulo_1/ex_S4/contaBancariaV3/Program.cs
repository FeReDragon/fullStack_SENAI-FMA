using System;
using contaBancariaV3.Classes;
using contaBancariaV3.Classes.enums;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nBem Vindo ao Lab365Bank\n");

        Cliente pessoaFisica = new Cliente("Fernando Aurelio", DateTime.Parse("1984-01-26"), "Desenvolvedor", "Casado", TipoPessoaEnum.FISICA);
        ContaCorrente contaCorrente = new ContaCorrente(2000, 1000, pessoaFisica);
        
        Console.WriteLine("Nome:" + pessoaFisica.Nome);
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(625);
        contaCorrente.ExibirSaldo();

        Cliente cliente = ClienteService.CadastrarCliente();
        ContaBancaria conta = ContaBancariaService.CadastrarConta(cliente);

        //  laço de repetição do, mostra ao usuário uma lista de opções para realizar transaçoes bancárias
        int opcao;
        do
        {
            Console.WriteLine("Selecione uma opção:\n1 - Saque\n2 - Depósito\n3 - Transferência\n4 - Empréstimo\n5 - Consultar Saldo\n6 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Insira o valor a ser sacado:");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 2:
                    Console.WriteLine("Insira o valor a ser depositado:");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case 3:
                    Console.WriteLine("Insira o valor a ser transferido:");
                    decimal valorTransferencia = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o número da conta destino:");
                    int numeroContaDestino = int.Parse(Console.ReadLine());
                    // Aqui precisaria buscar a conta destino na sua base de dados
                    ContaBancaria contaDestino = new ContaBancaria(numeroContaDestino, conta.Agencia, cliente);
                    conta.Transferir(contaDestino, valorTransferencia);
                    break;
                case 4:
                    if (conta is ContaEmpresarial)
                    {
                        Console.WriteLine("Insira o valor do empréstimo:");
                        decimal valorEmprestimo = decimal.Parse(Console.ReadLine());
                        (conta as ContaEmpresarial).FazerEmprestimo(valorEmprestimo);
                    }
                    else
                    {
                        Console.WriteLine("Esta opção só está disponível para contas empresariais!");
                    }
                    break;
                case 5:
                    Console.WriteLine("Nome: " + cliente.Nome + "\nConta: " + conta.Numero + 
                    "\nAgência: " + conta.Agencia + "\nTipo de conta: " + conta.GetType().Name + 
                    "\nData/hora da consulta: " + 
                    DateTime.Now + "\nSaldo: R$ " + conta.Saldo);
                    break;
            }
        } while (opcao != 6);
        Console.WriteLine("Obrigado por utilar Lab365Bank!");
    }
}