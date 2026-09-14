using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Exceptions.Enums;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Globalization;

namespace GestaoVeiculos.Presenters;

public class VeiculoPresenter
{
    private readonly IVeiculoView _view;
    private readonly IVeiculoRepository _repository;
    private readonly IMarcaRepository _marcaRepository;
    public VeiculoPresenter(IVeiculoView view, IVeiculoRepository repository, IMarcaRepository marcaRepository )
    {
        _view = view;
        _repository = repository;
        _marcaRepository = marcaRepository;
        _view.ClickBtnCadastrar += CadastrarVeiculo;
        _view.ClickBtnEditar += EditarVeiculo;
        _view.ClickBtnExcluir += ExcluirVeiculo;
        _view.FormLoad += ListarVeiculos;
        _view.FormLoad += ExibirMarcas;
    }

    private void ValidarIdInvalido(int id)
    {
        if (id == 0)
        {
            throw new VeiculoException("O campo 'código' não pode ficar em branco.", VeiculoErrorCode.IdInvalido);
        }
    }

    private void ListarVeiculos(object sender, EventArgs e)
    {
        _view.ListarVeiculos(_repository.ListarTodos());
    }

    private void ExibirMarcas(object sender, EventArgs e)
    {
        _view.ExibirMarcas(_marcaRepository.ListarTodos());
    }


    private void CadastrarVeiculo(object sender, EventArgs e)
    {
        try
        {
            Veiculo veiculo = VeiculoFactory.CriarVeiculo(_view.TipoVeiculo, 
                _view.Placa, _view.Modelo, _view.Ano, _view.MarcaId);
            
            _repository.Cadastrar(veiculo);
            _view.ExibirMensagem("Veículo cadastrado com sucesso!");
            _view.ListarVeiculos(_repository.ListarTodos());
            _view.LimparCampos();
            _view.AtivaCbTipoVeiculo();
        }
        catch (VeiculoException ex)
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
                    if (!pgEx.ConstraintName.Contains("ano"))
                    {
                        if (pgEx.ConstraintName.Contains("marca_id"))
                        {
                            _view.ExibirMensagem($"O veículo deve possuir uma marca válida.");
                            return;
                        }
                        _view.ExibirMensagem($"O campo '{pgEx.ConstraintName.Replace("ck_veiculo_", "")}' é obrigatório.");
                    }
                    else _view.ExibirMensagem($"O ano do veículo deve ser entre 1950 e {DateTime.Today.Year.ToString(CultureInfo.InvariantCulture)}.");
                    break;
                case PostgresErrorCodes.UniqueViolation:
                    _view.ExibirMensagem($"Já existe um veículo com este(a) {pgEx.ConstraintName.Replace("uq_veiculo_", "")}.");
                    break;
                case PostgresErrorCodes.StringDataRightTruncation:
                    _view.ExibirMensagem($"Um dos campos ultrapassou o limite de caracteres permitido.");
                    break;
            }
        }
    }

    private void EditarVeiculo(object sender, EventArgs e)
    {
        try
        {
            ValidarIdInvalido(_view.Id);

            Veiculo veiculo = VeiculoFactory.CriarVeiculo(_view.TipoVeiculo,
                _view.Placa, _view.Modelo, _view.Ano, _view.MarcaId);
            veiculo.Id = _view.Id;


            _repository.Alterar(veiculo);
            _view.ExibirMensagem("Informações do veículo alteradas com sucesso!");
            _view.ListarVeiculos(_repository.ListarTodos());
            _view.LimparCampos();
            _view.AtivaCbTipoVeiculo();
        }
        catch (VeiculoException ex)
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
                    if (!pgEx.ConstraintName.Contains("ano"))
                    {
                        if (pgEx.ConstraintName.Contains("marca_id"))
                        {
                            _view.ExibirMensagem($"O veículo deve possuir uma marca válida.");
                            return;
                        }
                        _view.ExibirMensagem($"O campo '{pgEx.ConstraintName.Replace("ck_veiculo_", "")}' é obrigatório.");
                    }
                    else _view.ExibirMensagem($"O ano do veículo deve ser entre 1950 e {DateTime.Today.Year.ToString(CultureInfo.InvariantCulture)}.");
                    break;
                case PostgresErrorCodes.UniqueViolation:
                    _view.ExibirMensagem($"Já existe um veículo com este(a) {pgEx.ConstraintName.Replace("uq_veiculo_", "")}.");
                    break;
                case PostgresErrorCodes.StringDataRightTruncation:
                    _view.ExibirMensagem($"Um dos campos ultrapassou o limite de caracteres permitido.");
                    break;
            }
        }
    }

    private void ExcluirVeiculo(object sender, EventArgs e)
    {
        try
        {
            ValidarIdInvalido(_view.Id);
            _repository.Excluir(_view.Id);
            _view.ExibirMensagem("Veículo excluído.");
            _view.ListarVeiculos(_repository.ListarTodos());
            _view.LimparCampos();
            _view.AtivaCbTipoVeiculo();
        }
        catch (VeiculoException ex)
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
            }
        }
    }
}