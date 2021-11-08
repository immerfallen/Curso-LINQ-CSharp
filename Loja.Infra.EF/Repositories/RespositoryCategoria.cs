using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra.EF.Repositories
{
    public class RespositoryCategoria
    {
        public void AdicionarCategoria(int id,string nome)
        {

            //Entity Framework
            Categoria categoria = new Categoria();
            categoria.Nome = nome;
            categoria.Id = id;

            LojaEntities ef = new LojaEntities();

            ef.Categoria.Add(categoria);
            

            ef.SaveChanges();

        }
    }
}
