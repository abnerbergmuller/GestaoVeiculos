using System;
using System.Collections.Generic;
using System.Text;
using GestaoVeiculos.Models;

namespace GestaoVeiculos.Data.Interfaces
{
    public interface IMarcaRepository
    {
        void Cadastrar(Marca marca);
        void Alterar(Marca marca);
        void Excluir(Marca marca);
        IEnumerable<Marca> ListarTodos();
    }
}
