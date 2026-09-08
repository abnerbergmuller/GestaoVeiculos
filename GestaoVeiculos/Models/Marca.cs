using System;
using System.Collections.Generic;

namespace GestaoVeiculos.Models;

public partial class Marca
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public Marca(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    public Marca(string nome)
    {
        Nome = nome;
    }

    public Marca()
    {
    }
}
