using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Models;
using Microsoft.EntityFrameworkCore;

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
            finally
            {
                _contexto.ChangeTracker.Clear();
            }
        }

        public void Alterar(Veiculo veiculo)
        {
            try
            {
                var veiculoEncontrado = _contexto.Veiculos.Find(veiculo.Id);
                veiculoEncontrado.Placa = veiculo.Placa;
                veiculoEncontrado.Modelo = veiculo.Modelo;
                veiculoEncontrado.Ano = veiculo.Ano;
                veiculoEncontrado.MarcaId = veiculo.MarcaId;
                _contexto.SaveChanges();
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
                var veiculo = _contexto.Veiculos.Find(veiculoId);
                _contexto.Veiculos.Remove(veiculo);
                _contexto.SaveChanges();
            }
            finally
            {
                _contexto.ChangeTracker.Clear();
            }
        }

        public IEnumerable<Veiculo> ListarTodos()
        {
            return _contexto.Veiculos.AsNoTracking().ToList();
        }
    }
}
