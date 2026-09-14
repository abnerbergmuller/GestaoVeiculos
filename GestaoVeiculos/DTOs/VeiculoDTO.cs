namespace GestaoVeiculos.DTOs;

public class VeiculoDTO
{
    public int Id { get; set; }
    public string Placa { get; set; } = null!;
    public string Modelo { get; set; } = null!;
    public int? Ano { get; set; }
    public string MarcaNome { get; set; } = null!;
    public string TipoVeiculo { get; set; } = null!;
}
