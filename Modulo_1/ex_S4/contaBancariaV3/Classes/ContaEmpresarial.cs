using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes.enums;

namespace contaBancariaV3.Classes
{
    // Esta é a classe ContaEmpresarial, que herda da classe ContaBancaria
    public class ContaEmpresarial : ContaBancaria
    {
        // Propriedades específicas de contas empresariais
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public decimal ValorUsado { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public string CNPJ { get; private set; }

        // Construtor da classe ContaEmpresarial, que chama o construtor da classe ContaBancaria e verifica se o cliente é uma pessoa jurídica
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            CNPJ = cnpj;

            // exceção para validar o Tipo da pessoa jurídica. 
            if (cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }
         // Método para fazer um empréstimo
        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0) 
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui um empréstimo ativo!");
                return;
            }

            if(valor > LimiteEmprestimo) 
            {
                Console.WriteLine("O valor ultrapassa seu limite de empréstimo disponível!");
                return;
            }

            PossuiEmprestimo = true;
            base.Depositar(valor);
            ValorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {valor} realizado com sucesso!");
        }
        
        // Método para parar um empréstimo
        public void PagarEmprestimo()
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);
            if(total > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento!");
                return;
            }

            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine("Empréstimo no valor total de R$" + total + " pago com sucesso!");
        }
        // Sobrescrita do método Sacar, adiciona uma taxa de R$ 1,00 ao valor a ser sacado
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 1,00 por saque
            valor += 1;
            base.Sacar(valor);
        }

        // Sobrescrita do método Transferir, que adiciona uma taxa de R$ 0,50 ao valor a ser transferido
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,50 por transferência
            valor += 0.50M;
            base.Transferir(conta, valor);
        }
    }
}