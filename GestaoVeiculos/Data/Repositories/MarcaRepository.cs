using System;
using System.Collections.Generic;
using System.Text;
using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoVeiculos.Data.Repositories
{
    internal class MarcaRepository : IMarcaRepository
    {
        private readonly AppDbContext _contexto;

        public void Alterar(Marca marca)
        {
            _contexto.Marcas.Update(marca);
            _contexto.SaveChanges();
        }

        public void Cadastrar(Marca marca)
        {
            _contexto.Marcas.Add(marca);
            _contexto.SaveChanges();
        }

        public void Excluir(Marca marca)
        {
            _contexto.Marcas.Remove(marca);
            _contexto.SaveChanges();
        }

        public IEnumerable<Marca> ListarTodos()
        {
            return _contexto.Marcas.AsNoTracking().ToList();
        }
    }
}
