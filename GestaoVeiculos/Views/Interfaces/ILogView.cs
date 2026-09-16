using GestaoVeiculos.DTOs;
using GestaoVeiculos.Models;

namespace GestaoVeiculos.Views.Interfaces;

public interface ILogView
{
    void ListarLogs(IEnumerable<LogTransacao> logTransacao, IEnumerable<LogErro> logErro);
    event EventHandler FormLoad;
}