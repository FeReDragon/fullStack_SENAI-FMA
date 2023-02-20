using System;

namespace contaBancariav2
{
    // Enum tipo de conta
    enum TipoConta
    {
        CORRENTE,
        POUPANCA
    }

    // Classe para a conta bancária
    class ContaBancaria
    {
        // atributos/propriedades privados da conta
        private int numeroConta;
        private int numeroAgencia;
        private string nomeTitular;
        private double saldo;
        private DateTime dataUltimaAtualizacao;
        private TipoConta tipo;

        // Propriedades públicas de acesso e modificação

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            set { numeroAgencia = value; }
        }

        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public DateTime DataUltimaAtualizacao
        {
            get { return dataUltimaAtualizacao; }
            set { dataUltimaAtualizacao = value; }
        }

        public TipoConta Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        // Construtor padrão
        public ContaBancaria()
        {

        }

        // Construtor para receber os valores dos atributos na instanciação da classe
        public ContaBancaria(string nomeTitular, int numeroAgencia, int numeroConta, TipoConta tipoConta)
        {
            this.nomeTitular = nomeTitular;
            this.numeroConta = numeroConta;
            this.numeroAgencia = numeroAgencia;
            this.tipo = tipoConta;
            this.saldo = 0;
        }

        // Método para depositar valor
        public void Depositar(double valor)
        {
            saldo += valor;
            dataUltimaAtualizacao = DateTime.Now;
        }

        // Método para sacar valor
        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                dataUltimaAtualizacao = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }

        // Método para transferir valor para outra conta
        public void Transferir(double valor, int numeroContaDestino)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor da transferência deve ser maior que zero.");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Transferência no valor de R${0} para conta {1} realizada com sucesso.", valor, numeroContaDestino);
            }
        }

        // Método para consultar saldo
        public void ConsultarSaldo()
        {
            Console.WriteLine("Número da conta: " + NumeroConta);
            Console.WriteLine("Nome do titular: " + NomeTitular);
            Console.WriteLine("Tipo de conta: " + Tipo);
            Console.WriteLine("Saldo: R$ " + Saldo.ToString("N2"));
            Console.WriteLine("Data da última atualização: " + DataUltimaAtualizacao);
        
        }
    }
}