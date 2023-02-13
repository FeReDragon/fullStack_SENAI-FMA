using System;

namespace contaBancaria
{
    // Enum tipo de conta
    enum TipoConta
    {
        CORRENTE,
        POUPANCA
    }

    // Classe para a conta bancária
    class Conta
    {
        // Propriedades da conta
        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public TipoConta Tipo { get; set; }

        // Método para depositar valor
        public void Depositar(double valor)
        {
            Saldo += valor;
            DataAtualizacao = DateTime.Now;
        }

        // Método para sacar valor
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                DataAtualizacao = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }

        // Método para consultar o saldo da conta
        public void ConsultarSaldo()
        {
            Console.WriteLine("Número da conta: " + NumeroConta);
            Console.WriteLine("Nome do titular: " + NomeTitular);
            Console.WriteLine("Tipo de conta: " + Tipo);
            Console.WriteLine("Saldo: R$ " + Saldo);
            Console.WriteLine("Data da última atualização: " + DataAtualizacao);
        }
    }
}