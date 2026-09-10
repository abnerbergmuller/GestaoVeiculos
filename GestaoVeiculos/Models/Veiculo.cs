using System;
using System.Collections.Generic;

namespace GestaoVeiculos.Models;

public abstract partial class Veiculo
{
    public int Id { get; set; }

    public string Placa { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int? Ano { get; set; }

    public int MarcaId { get; set; }

    public virtual Marca Marca { get; set; } = null!;

    protected Veiculo(int id, string placa, string modelo, int? ano, int marcaId, Marca marca)
    {
        Id = id;
        Placa = placa;
        Modelo = modelo;
        Ano = ano;
        MarcaId = marcaId;
        Marca = marca;
    }

    protected Veiculo(string placa, string modelo, int? ano, int marcaId)
    {
        Placa = placa;
        Modelo = modelo;
        Ano = ano;
        MarcaId = marcaId;
    }

    protected Veiculo()
    {
    }
}
