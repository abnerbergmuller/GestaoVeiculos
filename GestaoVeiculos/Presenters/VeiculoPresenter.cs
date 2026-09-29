using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Globalization;
using System.Reflection;

namespace GestaoVeiculos.Presenters;

public class VeiculoPresenter
{
    private readonly IVeiculoView _view;
    private readonly IVeiculoRepository _repository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly ILogRepository _logRepository;
    public VeiculoPresenter(IVeiculoView view, IVeiculoRepository repository, IMarcaRepository marcaRepository, ILogRepository logRepository)
    {
        _view = view;
        _repository = repository;
        _marcaRepository = marcaRepository;
        _logRepository = logRepository;
        _view.ClickBtnCadastrar += CadastrarVeiculo;
        _view.ClickBtnEditar += EditarVeiculo;
        _view.ClickBtnExcluir += ExcluirVeiculo;
        _view.FormLoad += ListarVeiculos;
        _view.FormLoad += ExibirMarcas;
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
        if (string.IsNullOrWhiteSpace(_view.TipoVeiculo))
        {
            _view.ExibirMensagem("Por favor, selecione o tipo de veículo antes de cadastrar.");
            return;
        }
        try
        {
            Veiculo veiculo = VeiculoFactory.MontarVeiculo(_view.TipoVeiculo, 
                _view.Placa, _view.Modelo, _view.Ano, _view.MarcaId);
            
            _repository.Cadastrar(veiculo);
            _view.ExibirMensagem("Veículo cadastrado com sucesso!");
            _view.ListarVeiculos(_repository.ListarTodos());
            _view.LimparCampos();
            _view.AtivaCbTipoVeiculo();
        }
        catch (BancoException bdEx)
        {
            _view.ExibirMensagem(bdEx.Message);
            _logRepository.RegistrarErro(new LogErro(bdEx.DataHora, bdEx.Mensagem,
                MethodBase.GetCurrentMethod().Name, bdEx.CodigoErro, bdEx.RastroCodigo));
        }
    }

    private void EditarVeiculo(object sender, EventArgs e)
    {
        if (_view.Id <= 0)
        {
            _view.ExibirMensagem("Selecione um veículo para editar.");
            return;
        }
        try
        {
            Veiculo veiculo = VeiculoFactory.MontarVeiculo(_view.TipoVeiculo,
                _view.Placa, _view.Modelo, _view.Ano, _view.MarcaId);
            veiculo.Id = _view.Id;


            _repository.Alterar(veiculo);
            _view.ExibirMensagem("Informações do veículo alteradas com sucesso!");
            _view.ListarVeiculos(_repository.ListarTodos());
            _view.LimparCampos();
            _view.AtivaCbTipoVeiculo();
        }
        catch (BancoException bdEx)
        {
            _view.ExibirMensagem(bdEx.Message);
            _logRepository.RegistrarErro(new LogErro(bdEx.DataHora, bdEx.Mensagem,
                MethodBase.GetCurrentMethod().Name, bdEx.CodigoErro, bdEx.RastroCodigo));
        }
    }

    private void ExcluirVeiculo(object sender, EventArgs e)
    {
        if (_view.Id <= 0)
        {
            _view.ExibirMensagem("Selecione um veículo para excluir.");
            return;
        }
        try
        {
            _repository.Excluir(_view.Id);
            _view.ExibirMensagem("Veículo excluído.");
            _view.ListarVeiculos(_repository.ListarTodos());
            _view.LimparCampos();
            _view.AtivaCbTipoVeiculo();
        }
        catch (BancoException bdEx)
        {
            _view.ExibirMensagem(bdEx.Message);
            _logRepository.RegistrarErro(new LogErro(bdEx.DataHora, bdEx.Mensagem,
                MethodBase.GetCurrentMethod().Name, bdEx.CodigoErro, bdEx.RastroCodigo));
        }
    }
}