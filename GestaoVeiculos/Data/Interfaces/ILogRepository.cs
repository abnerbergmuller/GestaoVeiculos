using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;

namespace GestaoVeiculos.Data.Interfaces;

public interface ILogRepository
{
    IEnumerable<LogTransacao> ListarTransacoes();
    IEnumerable<LogErro> ListarErros();
    void RegistrarErro(LogErro logErro);

}