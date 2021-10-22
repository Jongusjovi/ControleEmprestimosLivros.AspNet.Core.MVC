using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Interfaces;
using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Models;

namespace ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Repositories
{
    public class RepositoryClientes : RepositoryBase<Clientes>, IRepositoryClientes
    {
        public RepositoryClientes(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
