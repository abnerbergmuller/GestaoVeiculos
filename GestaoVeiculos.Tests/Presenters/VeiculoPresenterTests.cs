using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using GestaoVeiculos.Presenters;
using GestaoVeiculos.Views.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace GestaoVeiculos.Tests.Presenters;

[TestFixture]
public class VeiculoPresenterTests
{
    private IVeiculoView _mockView;
    private IVeiculoRepository _mockRepository;
    private IMarcaRepository _mockMarcaRepository;
    private ILogRepository _mockLogRepository;
    private VeiculoPresenter _presenter;

    [SetUp]
    public void Setup()
    {
        _mockView = Substitute.For<IVeiculoView>();
        _mockRepository = Substitute.For<IVeiculoRepository>();
        _mockMarcaRepository = Substitute.For<IMarcaRepository>();
        _mockLogRepository = Substitute.For<ILogRepository>();
        _mockView.TipoVeiculo.Returns("Carro");

        _presenter = new VeiculoPresenter(_mockView, _mockRepository, _mockMarcaRepository, _mockLogRepository);
    }
        
    //Teste unitário da regra de negócio "ano entre 1950 e o ano atual".
    [Test]
    public void Cadastrar_AnoMenorQue1950_DeveExibirMensagemDeErro()
    {
        _mockView.Ano.Returns(1940);
        _mockRepository.When(r => r.Cadastrar(Arg.Any<Veiculo>()))
            .Do(_ => throw new BancoException("O ano do veículo deve ser entre 1950 e 2026."));
        
        _mockView.ClickBtnCadastrar += Raise.Event<EventHandler>(this, EventArgs.Empty);

        _mockView.Received(1).ExibirMensagem(Arg.Is<string>(msg => msg.Contains("1950")));
    }
    
    //Testes unitários da regra de negócio "placa obrigatória e única" 
    [Test]
    public void Cadastrar_PlacaObrigatoria_DeveExibirMensagemDeErro()
    {
        _mockView.Placa.Returns("");
        _mockRepository.When(r => r.Cadastrar(Arg.Any<Veiculo>()))
            .Do(_ => throw new BancoException($"O campo 'placa' é obrigatório."));

        _mockView.ClickBtnCadastrar += Raise.Event<EventHandler>(this, EventArgs.Empty);
        
        _mockView.Received(1).ExibirMensagem(Arg.Is<string>(msg => msg.Contains("placa")));
    }
    
    [Test]
    public void Cadastrar_PlacaJaExistenteNoBanco_DeveExibirMensagemDeErro()
    {
        _mockView.Placa.Returns("ASC7C89");
        _mockRepository.When(r => r.Cadastrar(Arg.Any<Veiculo>()))
            .Do(_ => throw new BancoException($"Já existe um registro com este(a) placa."));

        _mockView.ClickBtnCadastrar += Raise.Event<EventHandler>(this, EventArgs.Empty);
        
        _mockView.Received(1).ExibirMensagem(Arg.Is<string>(msg => msg.Contains("placa")));
    }
}
