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

            var viewMarca = new FrmCadastroMarca();
            var repositoryMarca = new MarcaRepository(contexto); 
            var presenterMarca = new MarcaPresenter(viewMarca, repositoryMarca);


            //Lembrar: instanciar só o menu principal, o restante das telas "por demanda"!!!
            Application.Run(viewMarca);
        }
    }
}