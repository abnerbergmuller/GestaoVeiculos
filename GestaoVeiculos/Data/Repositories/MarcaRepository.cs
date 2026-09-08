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

        public void Alterar(Marca marca)
        {
            try
            {
                var marcaExistente = _contexto.Marcas.Find(marca.Id);
                if (marcaExistente != null)
                {
                    marcaExistente.Nome = marca.Nome;
                    _contexto.SaveChanges();
                }
            }
            finally
            {
                _contexto.ChangeTracker.Clear();
            }
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

        public void Excluir(int marcaId)
        {
            try
            {
                var marca = _contexto.Marcas.Find(marcaId);
                if (marca != null)
                {
                    _contexto.Marcas.Remove(marca);
                    _contexto.SaveChanges();
                }
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

        public bool NomeIgualAtual(Marca marca)
        {
            return _contexto.Marcas.Any(n => n.Nome == marca.Nome && n.Id == marca.Id);
        }
    }
}
