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

        public List<Produto> Listar()
        {
            _produto.Add(new Produto(){Id = Guid.NewGuid(),Nome = "Banana",Quantidade = 5,Valor = 5,DataVencimento = DateTime.Now.AddDays(5)});
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Melancia", Quantidade = 11, Valor = 6, DataVencimento = DateTime.Now.AddDays(2) });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Manga", Quantidade = 2, Valor = 9, DataVencimento = DateTime.Now.AddDays(25) });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Uva", Quantidade = 3, Valor = 25, DataVencimento = DateTime.Now.AddDays(9) });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 1, Valor = 85, DataVencimento = DateTime.Now.AddDays(36) });
            _produto.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pessego", Quantidade = 2, Valor = 59, DataVencimento = DateTime.Now.AddDays(14) });
            return _produto;
        }
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataVencimento { get; set; }
}
}
