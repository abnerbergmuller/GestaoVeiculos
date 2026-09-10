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

        public MarcaRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }


        public void Cadastrar(Marca marca)
        {
            try
            {
                _contexto.Marcas.Add(marca);
                _contexto.SaveChanges();
            }
            finally
            {
                _contexto.ChangeTracker.Clear();
            }
        }

        public void Alterar(Marca marca)
        {
            try
            {
                var marcaEncontrada = _contexto.Marcas.Find(marca.Id);
                marcaEncontrada.Nome = marca.Nome;
                _contexto.SaveChanges();
            }
            finally
            {
                _contexto.ChangeTracker.Clear();
            }
        }

        public void Excluir(int marcaId)
        {
            try
            {
                var marca = new Marca{Id = marcaId};
                _contexto.Marcas.Remove(marca);
                _contexto.SaveChanges();
            }
            finally
            {
                _contexto.ChangeTracker.Clear();
            }
        }

        public IEnumerable<Marca> ListarTodos()
        {
            return _contexto.Marcas.AsNoTracking().ToList();
        }
    }
}
