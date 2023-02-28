using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes.enums;

namespace contaBancariaV3.Classes
{
    public class ContaBancariaService
    {
        // Esta é a classe ContaBancariaService, que fornece serviços relacionados a contas bancárias
        public static ContaBancaria CadastrarConta(Cliente cliente)
        {
            // Método estático que permite cadastrar uma nova conta bancária e retorna a instância da classe ContaBancaria correspondente.
            Console.WriteLine("Insira o número da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a agência:");
            int agencia = int.Parse(Console.ReadLine());

            // Verifica o tipo de pessoa do cliente e solicita informações adicionais se for uma conta empresarial
            if (cliente.TipoPessoa == TipoPessoaEnum.FISICA)
            {
                Console.WriteLine("Você deseja criar uma conta corrente ou poupança? (CORRENTE ou POUPANCA)");
                string tipoConta = Console.ReadLine();

                 // Retorna uma nova instância da classe ContaCorrente ou ContaPoupanca de acordo com o tipo de conta selecionado
                if (tipoConta == "CORRENTE")
                {
                    return new ContaCorrente(numero, agencia, cliente);
                }
                else
                {
                    return new ContaPoupanca(numero, agencia, cliente);
                }
            }
            else
            {
                Console.WriteLine("Insira o limite de empréstimo:");
                decimal limiteEmprestimo = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Insira a taxa de juros:");
                decimal taxaJuros = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Insira o CNPJ:");
                string cnpj = Console.ReadLine();

                // Retorna uma nova instância da classe ContaEmpresarial com as informações fornecidas
                return new ContaEmpresarial(numero, agencia, cliente, limiteEmprestimo, taxaJuros, cnpj);
            }
        }
    }
}