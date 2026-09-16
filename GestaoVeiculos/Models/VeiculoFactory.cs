namespace GestaoVeiculos.Models;

public class VeiculoFactory
{
    public static Veiculo MontarVeiculo(string tipoSelecionado, string placa, string modelo, int? ano, int marcaId)
    {
        return tipoSelecionado switch
        {
            "Carro" => new Carro(placa, modelo, ano, marcaId),
            "Moto" => new Moto(placa, modelo, ano, marcaId)
        };
    }
}