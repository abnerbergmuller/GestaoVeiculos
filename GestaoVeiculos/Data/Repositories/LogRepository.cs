using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Exceptions;
using GestaoVeiculos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;

namespace GestaoVeiculos.Data.Repositories;

public class LogRepository : ILogRepository
{
    private readonly AppDbContext _contexto;

    public LogRepository(AppDbContext contexto)
    {
        _contexto = contexto;
    }

    public IEnumerable<LogTransacao> ListarTransacoes()
    {
        return _contexto.LogTransacoes.AsNoTracking().OrderByDescending(l => l.DataHora).ToList();
    }
    public IEnumerable<LogErro> ListarErros()
    {
        return _contexto.LogsErro.AsNoTracking().OrderByDescending(l => l.DataHora).ToList();
    }

    public void RegistrarErro(LogErro logErro)
    {
        try
        {
            _contexto.LogsErro.Add(logErro);
            _contexto.SaveChanges();
        }
        finally
        {
            _contexto.ChangeTracker.Clear();
        }
    }
}