using System;
using System.Collections.Generic;

namespace GestaoVeiculos.Models;

public partial class LogTransacao
{
    public int Id { get; set; }

    public string? TipoOperacao { get; set; }

    public DateTime? DataHora { get; set; }

    public int? VeiculoId { get; set; }
}
