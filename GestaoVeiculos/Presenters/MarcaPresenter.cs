using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace GestaoVeiculos.Presenters
{
    public class MarcaPresenter
    {
        private readonly IMarcaView _view;
        private readonly IMarcaRepository _repository;
        private readonly ILogRepository _logRepository;

        public MarcaPresenter(IMarcaView view, IMarcaRepository repository, ILogRepository logRepository)
        {
            _view = view;
            _repository = repository;
            _logRepository = logRepository;
            _view.ClickBtnCadastrar += CadastrarMarca;
            _view.ClickBtnEditar += EditarMarca;
            _view.ClickBtnExcluir += ExcluirMarca;
            _view.FormLoad += ListarMarcas;
        }


        private void ListarMarcas(object sender, EventArgs e)
        {
            _view.ListarMarcas(_repository.ListarTodos());
        }

        private void CadastrarMarca(object sender, EventArgs e)
        {
            try
            {
                var marca = new Marca(_view.Nome);
                _repository.Cadastrar(marca);
                _view.ExibirMensagem("Marca cadastrada com sucesso!");
                _view.ListarMarcas(_repository.ListarTodos());
                _view.LimparCampos();
            }
            catch (BancoException bdEx)
            {
                _view.ExibirMensagem(bdEx.Message);
                _logRepository.RegistrarErro(new LogErro(bdEx.DataHora, bdEx.Mensagem,
                    MethodBase.GetCurrentMethod().Name, bdEx.CodigoErro, bdEx.RastroCodigo));
            }
        }

        private void EditarMarca(object sender, EventArgs e)
        {
            if (_view.Id <= 0)
            {
                _view.ExibirMensagem("Selecione uma marca para editar.");
                return;
            }
            try
            {
                var marca = new Marca(_view.Id, _view.Nome);
                _repository.Alterar(marca);
                _view.ExibirMensagem("O nome da marca foi alterado com sucesso.");
                _view.ListarMarcas(_repository.ListarTodos());
                _view.LimparCampos();
            }
            catch (BancoException bdEx)
            {
                _view.ExibirMensagem(bdEx.Message);
                _logRepository.RegistrarErro(new LogErro(bdEx.DataHora, bdEx.Mensagem,
                    MethodBase.GetCurrentMethod().Name, bdEx.CodigoErro, bdEx.RastroCodigo));
            }
        }

        private void ExcluirMarca(object sender, EventArgs e)
        {
            if (_view.Id <= 0)
            {
                _view.ExibirMensagem("Selecione uma marca para excluir.");
                return;
            }
            try
            {
                _repository.Excluir(_view.Id);
                _view.ExibirMensagem("Marca excluída.");
                _view.ListarMarcas(_repository.ListarTodos());
                _view.LimparCampos();
            }
            catch (BancoException bdEx)
            {
                _view.ExibirMensagem(bdEx.Message);
                _logRepository.RegistrarErro(new LogErro(bdEx.DataHora, bdEx.Mensagem,
                    MethodBase.GetCurrentMethod().Name, bdEx.CodigoErro, bdEx.RastroCodigo));
            }
        }
    }
}
