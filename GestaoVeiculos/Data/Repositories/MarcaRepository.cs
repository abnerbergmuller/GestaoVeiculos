using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

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
            catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx)
            {
                throw BancoException.Validar(pgEx);
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
                _contexto.Marcas.Update(marca);
                _contexto.SaveChanges();
            }
            catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx)
            {
                throw BancoException.Validar(pgEx);
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
                _contexto.Marcas.Where(m => m.Id == marcaId).ExecuteDelete();
            }
            catch (PostgresException pgEx)
            {
                throw BancoException.Validar(pgEx);
            }
        }

        public IEnumerable<Marca> ListarTodos()
        {
            return _contexto.Marcas.AsNoTracking().ToList();
        }
    }
}
