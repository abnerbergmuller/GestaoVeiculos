using System;
using System.Collections.Generic;

namespace GestaoVeiculos.Models;

public partial class LogErro
{
    public int Id { get; set; }

    public DateTime DataHora { get; set; }

    public string Mensagem { get; set; } = null!;

    public string LocalErro { get; set; } = null!;

    public string? CodigoErro { get; set; }

    public string? RastroCodigo { get; set; }
}
