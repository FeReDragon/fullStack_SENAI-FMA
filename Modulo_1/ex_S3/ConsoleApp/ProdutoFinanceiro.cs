using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ProdutoFinanceiro : Produto
    {
        public void acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.nome = "Produto Financeiro";
            cor = "Vermelho";
            Console.WriteLine("Nome: " + PF1.nome + " Cor: " + cor);
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
        }
    }
}