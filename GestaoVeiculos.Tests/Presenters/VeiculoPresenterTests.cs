using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Presenters;
using GestaoVeiculos.Views.Interfaces;
using NSubstitute;

namespace GestaoVeiculos.Tests;

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

        _presenter = new VeiculoPresenter(_mockView, _mockRepository, _mockMarcaRepository, _mockLogRepository);
    }
        
    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
