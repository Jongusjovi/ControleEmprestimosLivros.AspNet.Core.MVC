using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Models;
using ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimosLivros.AspNet.Core.MVC.WEB.Controllers
{
    public class ClientesController : Controller
    {
        private ClientesService clientesService = new ClientesService();
        public IActionResult Index()
        {
            List<Clientes> listaClientes = clientesService.repositoryClientes.SelecionarTodos();
            return View(listaClientes);
        }
    }
}
