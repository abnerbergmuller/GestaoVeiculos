namespace GestaoVeiculos.Models;

public class Carro : Veiculo
{
    public Carro(int id, string placa, string modelo, int? ano, int marcaId) 
        : base(id, placa, modelo, ano, marcaId)
    {
    }

    public Carro(string placa, string modelo, int? ano, int marcaId) 
        : base(placa, modelo, ano, marcaId)
    {
    }

    public Carro()
    {
    }
}
