using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes.enums;

namespace contaBancariaV3.Classes
{
    // Esta é a classe ContaCorrente, que herda da classe ContaBancaria
    public class ContaCorrente : ContaBancaria
    {
        // Construtor da classe ContaCorrente, que chama o construtor da classe ContaBancaria e verifica se o cliente é uma pessoa física
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            // Aexceção para validar o Tipo da pessoa física.
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // Sobrescrita do método Sacar, adiciona uma taxa de R$ 0,50 ao valor a ser sacado
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,50 por saque
            valor += 0.50M;
            base.Sacar(valor);
        }

        // Sobrescrita do método Transferir, adiciona uma taxa de R$ 0,25 ao valor a ser transferido
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,25 por transferência
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}