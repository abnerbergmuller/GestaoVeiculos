namespace GestaoVeiculos.Models;

public class Moto : Veiculo
{
    public Moto(int id, string placa, string modelo, int? ano, int marcaId, Marca marca) 
        : base(id, placa, modelo, ano, marcaId, marca)
    {
    }

    public Moto(string placa, string modelo, int? ano, int marcaId) 
        : base(placa, modelo, ano, marcaId)
    {
    }

    public Moto()
    {
    }
}