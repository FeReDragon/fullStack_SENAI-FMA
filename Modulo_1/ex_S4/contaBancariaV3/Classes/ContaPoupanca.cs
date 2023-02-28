using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes.enums;

namespace contaBancariaV3.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            // exceção para validar o Tipo da pessoa física.
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,10 por saque
            valor += 0.10M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,05 por transferência
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
}