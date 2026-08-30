using System;
using System.Collections.Generic;

namespace GestaoVeiculos.Models;

public partial class Veiculo
{
    public int Id { get; set; }

    public string Placa { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int? Ano { get; set; }

    public string TipoVeiculo { get; set; } = null!;

    public int MarcaId { get; set; }

    public virtual Marca Marca { get; set; } = null!;
}
