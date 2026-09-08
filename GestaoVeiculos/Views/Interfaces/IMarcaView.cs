using GestaoVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace GestaoVeiculos.Views.Interfaces
{
    public interface IMarcaView
    {
        int Id { get; set; }
        string Nome { get; set; }
        event EventHandler ClickBtnCadastrar;
        event EventHandler ClickBtnEditar;
        event EventHandler ClickBtnExcluir;
        event EventHandler FormLoad;
        void ListarTabMarcas(IEnumerable<Marca> marca);
        void ExibirMensagem(string mensagem);
    }
}
