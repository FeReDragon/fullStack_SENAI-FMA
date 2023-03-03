using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ProdutoFinanceiro : Produto
    // A classe "ProdutoFinanceiro" herda da classe "Produto" e tem acesso aos atributos e métodos da classe mãe.
    {
        public void acesso()// O método "acesso" cria um objeto "ProdutoFinanceiro", imprime o nome e a cor na tela 
        // e chama os métodos "vender" e "verificarEstoque" do objeto "ProdutoFinanceiro".
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