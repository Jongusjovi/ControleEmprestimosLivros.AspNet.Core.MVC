using System;

namespace ControleEmprestimosLivros.AspNet.Core.MVC.WEB.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
