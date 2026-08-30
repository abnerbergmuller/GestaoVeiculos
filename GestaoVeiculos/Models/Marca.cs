using System;
using System.Collections.Generic;

namespace GestaoVeiculos.Models;

public partial class Marca
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
