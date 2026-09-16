using GestaoVeiculos.Data.Interfaces;
using GestaoVeiculos.Models;
using GestaoVeiculos.Views.Interfaces;

namespace GestaoVeiculos.Presenters;

public class LogPresenter
{
    private readonly ILogView _view;
    private readonly ILogRepository _repository;

    public LogPresenter(ILogView view, ILogRepository repository)
    {
        _view = view;
        _repository = repository;
        _view.FormLoad += ListarLogs;
    }

    public void ListarLogs(object sender, EventArgs e)
    {
        _view.ListarLogs(_repository.ListarTransacoes(), _repository.ListarErros());
    }
}