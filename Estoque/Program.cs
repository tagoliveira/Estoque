using System;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe produto
            Produto objeto_instanciado_produto = new Produto();
            //objeto_instanciado_produto.nome_produto = "Melancia";
            //objeto_instanciado_produto.preco = 10;
            //Console.WriteLine("Produto = " + objeto_instanciado_produto.nome_produto);
            //Console.WriteLine("Preço = " + objeto_instanciado_produto.preco);
            /*objeto_instanciado_produto.setNome("Melancia");
            Console.WriteLine("Produto = " + objeto_instanciado_produto.getNome());
            objeto_instanciado_produto.setPreco(10);
            Console.WriteLine("Preço = " + objeto_instanciado_produto.getPreco());
            objeto_instanciado_produto.setNome("Melão");
            Console.WriteLine("Produto = " + objeto_instanciado_produto.getNome());
            objeto_instanciado_produto.setPreco(5);
            Console.WriteLine("Preço = " + objeto_instanciado_produto.getPreco());
            */
            //objeto_instanciado_produto.setPreco(10);
            //Console.WriteLine("Preço = " + objeto_instanciado_produto.getPreco());
            objeto_instanciado_produto.Nome_produto = "Melancia";
            Console.WriteLine("Produto = " + objeto_instanciado_produto.Nome_produto);
            objeto_instanciado_produto.Preco = 10;
            Console.WriteLine("Preço = " + objeto_instanciado_produto.Preco);

            Console.ReadKey();
        }
    }
}
