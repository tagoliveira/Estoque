using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    //public = sem restricoes
    //private = somente podem ser acessados na classe
    //protected = semelhante ao private e podem ser acessados de outras classes
    //internal e protected internal
    public class Produto
    {
        private string nome_produto;
        private double preco;

        public Produto() //metodo construtor
        {
            Console.WriteLine("Iniciou a classe Produto atravéz de seu método Construtor");
        }

        /*public void setNome (string nome_produto)
        {
            this.nome_produto = nome_produto;
        }

        public string getNome()
        {
            return nome_produto;
        }*/

        public string Nome_produto
        {
            get { return nome_produto; }
            set { nome_produto = value; }
        }

        /*public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public double getPreco()
        {
            return preco;
        }*/
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
