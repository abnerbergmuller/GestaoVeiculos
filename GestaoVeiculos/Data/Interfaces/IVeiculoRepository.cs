using GestaoVeiculos.Models;

namespace GestaoVeiculos.Data.Interfaces;

public interface IVeiculoRepository
{
    void Cadastrar(Veiculo veiculo);
    void Alterar(Veiculo veiculo);
    void Excluir(int veiculoId);
    IEnumerable<Veiculo> ListarTodos();
}