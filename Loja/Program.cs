using Loja.Domain.Entities;
using Loja.Infra.EF.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {


            //Salvando categoria com o Entity

            new RespositoryCategoria().AdicionarCategoria(1, "Frutas");
            new RespositoryCategoria().AdicionarCategoria(2, "Eletronicos");



            /* var frutas = new Produto().ListarFrutas();
            var eletronicos = new Produto().ListarEletronicos();

            var produtos = new List<Produto>();
            produtos.AddRange(frutas);
            produtos.AddRange(eletronicos);

            produtos.ForEach(x =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(x));
            });

            Console.WriteLine("---------------");

            var resultado = (from p in produtos
                             group p by p.Categoria into grupo
                             select new RelatorioProdutoPorCategoria
                             {
                                 NomeDaCategoria = grupo.Key,
                                 ValorMinimo = grupo.Min(x => x.Valor),
                                 ValorMaximo = grupo.Max(x => x.Valor),
                                 ValorTotal = grupo.Sum(x => x.Valor)
                             }).OrderBy(x => x.NomeDaCategoria);

            Console.WriteLine(JsonConvert.SerializeObject(resultado));

            resultado.ToList().ForEach(x =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(x));
            }); */


            //var valorProdutoMaisCaro = produtos.Max(x => x.Valor);

            ////menor

            //var maiorQuantEmEstoque = produtos.Min(x => x.Quantidade);

            ////Media do valor em estoque

            //var mediaValorEmEstoque = produtos.Average(x => x.Valor);

            ////maior

            //var maiorQuantEmEstoque = produtos.Max(x => x.Quantidade);

            ////menor

            //var soma = produtos.Sum(x => x.Valor);

            //var repetir = Enumerable.Repeat("Maro", 10);

            //var sequencia = Enumerable.Range(10, 20);

            //int[] numerosPares = { 2, 4, 6, 8, 10 };
            //int[] numerosImpares = { 1, 3, 5, 7, 9 };
            //int[] numerosMisturados = { 1, 2, 3, 4 };

            //var temNumeroPares = numerosMisturados.Intersect(numerosPares);

            //var numerosQueNaoSeRepetem = numerosMisturados.Except(numerosPares);



            //var produtos1 = new Produto().Listar();

            //var produtos2 = new Produto().Listar();
            //produtos2.Add(new Produto() {Nome="Galaxy", Valor= 2500 });
            //produtos2.Add(new Produto() { Nome = "Iphone X", Valor = 7900 });

            //produtos1.AddRange(produtos2);

            //produtos1.ForEach(p => Console.WriteLine(JsonConvert.SerializeObject(p)));

            //List<Produto> produtos2 = new List<Produto>();

            //if (produtos.Any(p=>p.Quantidade>10))
            //{
            //    Console.WriteLine("Tem itens");
            //}

            //var produto2 = produtos.LastOrDefault();

            //var produto1 = produtos.Last(); 

            //var produto2 = produtos.FirstOrDefault();

            //var produto1 = produtos.First(); // O First levanta execessão caso o objeto seja vazio enquanto o firstOrDefault passa o null como retorno.


            //produtos.ForEach(p =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(p));
            //});

            //var produtos = new Produto();
            //produtos.Listar()
            //.Where(x => x.Nome.StartsWith("P") || x.Nome.EndsWith("a"))
            //.ToList()
            //.ForEach(x =>
            ////.Where(x => x.Nome.Contains("e"))
            ////.ToList()
            ////.ForEach(x =>
            //    {
            //        Console.WriteLine(JsonConvert.SerializeObject(x));
            //        Console.WriteLine(" ");

            //    });

            //var prods = new Produto().Listar();
            //var nomes = prods
            //    .Where(x => x.Nome.StartsWith("P") || x.Nome.EndsWith("a"))
            //    .Select(p => new ProdutoSelecionado { Name = p.Nome.Substring(1,2).Insert(2,"Maro").Remove(2,2).Replace("a", "L"), Value = p.Valor })
            //    .ToList();
            //nomes.ForEach(item =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(item));
            //});

            //var prod = new Produto().Listar();
            //var itens = prods
            //    .Where(x => x.DataVencimento.Day>3)
            //    .Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor })
            //    .ToList();
            //nomes.ForEach(item =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(item));
            //});

            //var pro = new Produto().Listar();
            //var it = pro
            //    .Where(x => x.DataVencimento.Year == 2021)
            //    .Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor })
            //    .ToList();
            //nomes.ForEach(item =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(item));
            //});


            Console.ReadKey();
        }

       /* public class ProdutoSelecionado
        {
            public string Name { get; set; }
            public decimal Value { get; set; }
        } */
    }

    /*public class RelatorioProdutoPorCategoria
    {
        public string NomeDaCategoria { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public decimal ValorTotal { get; set; }
    } */
}
