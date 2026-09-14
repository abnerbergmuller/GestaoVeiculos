using GestaoVeiculos.DTOs;
using GestaoVeiculos.Models;

namespace GestaoVeiculos.Views.Interfaces;

public interface IVeiculoView
{
    int Id { get; set; }
    string Placa { get; set; }
    string Modelo { get; set; } 
    int? Ano { get; set; }
    int MarcaId { get; set; }
    string TipoVeiculo { get; set; }

    event EventHandler ClickBtnCadastrar;
    event EventHandler ClickBtnEditar;
    event EventHandler ClickBtnExcluir;
    event EventHandler FormLoad;
    void ListarVeiculos(IEnumerable<VeiculoDTO> veiculo);
    void ExibirMensagem(string mensagem);
    void LimparCampos();
    void AtivaCbTipoVeiculo();
    void ExibirMarcas(IEnumerable<Marca> marca);
}