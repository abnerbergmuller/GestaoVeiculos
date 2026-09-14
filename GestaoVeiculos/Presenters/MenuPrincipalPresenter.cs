using GestaoVeiculos.Data;
using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Data.Repositories;
using GestaoVeiculos.Views;
using GestaoVeiculos.Views.Interfaces;

namespace GestaoVeiculos.Presenters;

public class MenuPrincipalPresenter
{
    private readonly IMenuPrincipalView _view;

    public MenuPrincipalPresenter(IMenuPrincipalView view)
    {
        _view = view;
        _view.ClickBtnMarcas += AbrirTelaMarcas;
        _view.ClickBtnVeiculos += AbrirTelaVeiculos;
        _view.ClickBtnLogs += AbrirTelaLogs;
    }

    public void AbrirTelaMarcas(object sender, EventArgs e)
    {
        var viewMarca = new FrmCadastroMarca();
        var repositoryMarca = new MarcaRepository(new AppDbContext());
        var presenterMarca = new MarcaPresenter(viewMarca, repositoryMarca);

        viewMarca.ShowDialog();
    }

    public void AbrirTelaVeiculos(object sender, EventArgs e)
    {
        var viewVeiculo = new FrmCadastroVeiculo();
        var repositoryVeiculo = new VeiculoRepository(new AppDbContext());
        var repositoryMarca = new MarcaRepository(new AppDbContext());
        var presenterVeiculo = new VeiculoPresenter(viewVeiculo, repositoryVeiculo, repositoryMarca);

        viewVeiculo.ShowDialog();
    }

    public void AbrirTelaLogs(object sender, EventArgs e)
    {
        //----
    }
}