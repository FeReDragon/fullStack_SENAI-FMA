using System;
using ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Cria um objeto do tipo Produto e atribui nome a ele e imprime na tela
        Produto produto1 = new Produto();
        produto1.nome = "Calculadora";
        produto1.verificarEstoque();
        Console.WriteLine("O nome do produto é: " + produto1.nome);

        // Cria um objeto do tipo ProdutoFinanceiro e atribui nome a ele
        ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
        classeFilha.nome = "Produto Financeiro";
        classeFilha.verificarEstoque();
        classeFilha.acesso();
    }
}