using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.DTOs;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GestaoVeiculos.Data.Repositories
{
    internal class VeiculoRepository : IVeiculoRepository
    {
        private readonly AppDbContext _contexto;

        public VeiculoRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Cadastrar(Veiculo veiculo)
        {
            try
            {
                _contexto.Veiculos.Add(veiculo);
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

        public void Alterar(Veiculo veiculo)
        {
            try
            {
                _contexto.Veiculos.Update(veiculo);
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

        public void Excluir(int veiculoId)
        {
            try
            {
                _contexto.Veiculos.Where(v => v.Id == veiculoId).ExecuteDelete();
            }
            catch (PostgresException pgEx)
            {
                throw BancoException.Validar(pgEx);
            }
        }

        public IEnumerable<VeiculoDTO> ListarTodos()
        {
            return _contexto.Veiculos
                .Include(v => v.Marca)
                .Select(v => new VeiculoDTO
                {
                    Id = v.Id,
                    Placa = v.Placa,
                    Modelo = v.Modelo,
                    Ano = v.Ano,
                    MarcaNome = v.Marca.Nome,
                    TipoVeiculo = v.TipoVeiculo
                })
                .AsNoTracking()
                .ToList();
        }
    }
}
