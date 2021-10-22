using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Repositories;

namespace ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Services
{
    public class ClientesService
    {
        public RepositoryClientes repositoryClientes { get; set; }

        public ClientesService()
        {
            repositoryClientes = new RepositoryClientes();
        }
    }
}
