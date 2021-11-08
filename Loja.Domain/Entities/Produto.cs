using System;
using System.Collections.Generic;

namespace Loja.Domain.Entities
{
    public class Produto
    {
        private List<Produto> _produto;
        public Produto()
        {
            _produto = new List<Produto>();
        }

        public List<Produto> ListarFrutas()
        {
            _produto.Add(new Produto(){Id = Guid.NewGuid(),Nome = "Banana",Quantidade = 5,Valor = 5,DataVencimento = DateTime.Now.AddDays(5), Categoria="Frutas"});
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Melancia", Quantidade = 11, Valor = 6, DataVencimento = DateTime.Now.AddDays(2), Categoria = "Frutas" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Manga", Quantidade = 2, Valor = 9, DataVencimento = DateTime.Now.AddDays(25), Categoria = "Frutas" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Uva", Quantidade = 3, Valor = 25, DataVencimento = DateTime.Now.AddDays(9), Categoria = "Frutas" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 1, Valor = 85, DataVencimento = DateTime.Now.AddDays(36), Categoria = "Frutas" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pessego", Quantidade = 2, Valor = 59, DataVencimento = DateTime.Now.AddDays(14), Categoria = "Frutas" });
            return _produto;
        }

        public List<Produto> ListarEletronicos()
        {
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Iphone", Quantidade = 5, Valor = 5, Categoria = "Eletronicos" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Samsung", Quantidade = 11, Valor = 6, Categoria = "Eletronicos" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Televidor", Quantidade = 2, Valor = 9, Categoria = "Eletronicos" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Mouse", Quantidade = 3, Valor = 25, Categoria = "Eletronicos" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Game", Quantidade = 1, Valor = 85, Categoria = "Eletronicos" });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Tablet", Quantidade = 2, Valor = 59, Categoria = "Eletronicos" });
            return _produto;
        }
        public Guid Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataVencimento { get; set; }
    public string Categoria { get;set;}

}
}
