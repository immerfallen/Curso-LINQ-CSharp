using Loja.Domain.Entities;
using System;
using System.Linq;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();
            var produtos = produto.Listar().Where(p => p.Valor> 15);

            foreach (Produto prod in produtos)
            {
                Console.WriteLine(prod.Nome + " " + prod.Valor);
            }

            new Produto().Listar().Where(x=>x.Valor<10).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Nome);
            });

            Console.ReadKey();
        }
    }
}
