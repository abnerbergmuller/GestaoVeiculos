using System;
using System.Collections.Generic;
using System.Text;
using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace GestaoVeiculos.Presenters
{
    //SÓ FALTA ADICIONAR ERRO DE VINCULO À VEICULOS E DIRECIONAMENTO DE ERROS EM GERAL PARA LOG ERROS
    public class MarcaPresenter
    {
        private readonly IMarcaView _view;
        private readonly IMarcaRepository _repository;

        public MarcaPresenter(IMarcaView view, IMarcaRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.ClickBtnCadastrar += CadastrarMarca;
            _view.ClickBtnEditar += EditarMarca;
            _view.ClickBtnExcluir += ExcluirMarca;
            _view.FormLoad += ListarMarcas;
        }

        private void ValidarIdInvalido(int id)
        {
            if (id == 0)
            {
                throw new MarcaException("O campo 'código' não pode ficar em branco.", MarcaErrorCode.IdInvalido);
            }
        }


        private void ListarMarcas(object sender, EventArgs e)
        {
            _view.ListarTabMarcas(_repository.ListarTodos());
        }

        private void CadastrarMarca(object sender, EventArgs e)
        {
            try
            {
                var marca = new Marca(_view.Nome);
                _repository.Cadastrar(marca);
                _view.ExibirMensagem("Marca cadastrada com sucesso!");
                _view.ListarTabMarcas(_repository.ListarTodos());
            }
            catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx)
            {
                switch (pgEx.SqlState)
                {
                    case PostgresErrorCodes.NotNullViolation:
                        _view.ExibirMensagem($"O campo '{pgEx.ColumnName}' não pode ser nulo.");
                        break;
                    case PostgresErrorCodes.CheckViolation:
                        _view.ExibirMensagem($"O campo '{pgEx.ConstraintName.Replace("ck_marca_", "")}' é obrigatório.");
                        break;
                    case PostgresErrorCodes.UniqueViolation:
                        _view.ExibirMensagem($"Já existe uma marca com este {pgEx.ConstraintName.Replace("uq_marca_", "")}.");
                        break;
                    case PostgresErrorCodes.StringDataRightTruncation:
                        _view.ExibirMensagem($"Um dos campos ultrapassou o limite de caracteres permitido.");
                        break;
                }
            }
        }

        private void EditarMarca(object sender, EventArgs e)
        {
            try
            {
                ValidarIdInvalido(_view.Id);
                var marca = new Marca(_view.Id, _view.Nome);
                _repository.Alterar(marca);
                _view.ExibirMensagem("O nome da marca foi alterado com sucesso.");
                _view.ListarTabMarcas(_repository.ListarTodos());
            }
            catch (MarcaException ex)
            {
                _view.ExibirMensagem(ex.Message);
            }
            catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx)
            {
                switch (pgEx.SqlState)
                {
                    case PostgresErrorCodes.NotNullViolation:
                        _view.ExibirMensagem($"O campo '{pgEx.ColumnName}' não pode ser nulo.");
                        break;
                    case PostgresErrorCodes.CheckViolation:
                        _view.ExibirMensagem($"O campo '{pgEx.ConstraintName.Replace("ck_marca_", "")}' é obrigatório.");
                        break;
                    case PostgresErrorCodes.UniqueViolation:
                        _view.ExibirMensagem($"Já existe uma marca com este {pgEx.ConstraintName.Replace("uq_marca_", "")}.");
                        break;
                    case PostgresErrorCodes.StringDataRightTruncation:
                        _view.ExibirMensagem($"Um dos campos ultrapassou o limite de caracteres permitido.");
                        break;
                }
            }
        }

        private void ExcluirMarca(object sender, EventArgs e)
        {
            try
            {
                ValidarIdInvalido(_view.Id);
                var marca = new Marca(_view.Id, _view.Nome);
                _repository.Excluir(marca.Id);
                _view.ExibirMensagem("Marca excluída.");
                _view.ListarTabMarcas(_repository.ListarTodos());
            }
            catch (MarcaException ex)
            {
                switch (ex.ErrorCode)
                {
                    case MarcaErrorCode.IdInvalido:
                        _view.ExibirMensagem(ex.Message);
                        break;
                }
            }
            catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx)
            {
                switch (pgEx.SqlState)
                {
                    case PostgresErrorCodes.NotNullViolation:
                        _view.ExibirMensagem($"O campo '{pgEx.ColumnName}' não pode ser nulo.");
                        break;
                }
            }
        }
    }
}
