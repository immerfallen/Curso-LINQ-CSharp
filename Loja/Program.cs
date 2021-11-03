using Loja.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {

            var produtos = new Produto();
            produtos.Listar()
            .Where(x => x.Nome.StartsWith("P") || x.Nome.EndsWith("a"))
            .ToList()
            .ForEach(x =>
            //.Where(x => x.Nome.Contains("e"))
            //.ToList()
            //.ForEach(x =>
                {
                    Console.WriteLine(JsonConvert.SerializeObject(x));
                    Console.WriteLine(" ");

                });

            var prods = new Produto().Listar();
            var nomes = prods
                .Where(x => x.Nome.StartsWith("P") || x.Nome.EndsWith("a"))
                .Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(1,2).Insert(2,"Maro").Remove(2,2).Replace("a", "L"), Value = p.Valor })
                .ToList();
            nomes.ForEach(item =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });

            var prod = new Produto().Listar();
            var itens = prods
                .Where(x => x.DataVencimento.Day>3)
                .Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor })
                .ToList();
            nomes.ForEach(item =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });

            var pro = new Produto().Listar();
            var it = pro
                .Where(x => x.DataVencimento.Year == 2021)
                .Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor })
                .ToList();
            nomes.ForEach(item =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            });


            Console.ReadKey();
        }

        public class ProdutoSelecionado
        {
            public string Name { get; set; }
            public decimal Value { get; set; }
        }
    }
}
