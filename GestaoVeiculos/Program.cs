using GestaoVeiculos.Data;
using GestaoVeiculos.Data.Repositories;
using GestaoVeiculos.Presenters;
using GestaoVeiculos.Views;

namespace GestaoVeiculos
{
    internal static class Program
    {
            [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var contexto = new AppDbContext();

            var viewMenuPrincipal = new FrmMenuPrincipal();
            var presenterMenuPrincipal = new MenuPrincipalPresenter(viewMenuPrincipal);

            Application.Run(viewMenuPrincipal);
        }
    }
}