using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud_sem_bd.Models;
using crud_sem_bd.Repository;

namespace crud_sem_bd.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioFuncionarios fun;
        public HomeController(ILogger<HomeController> logger, RepositorioFuncionarios funcionario) {
            _logger = logger;
            fun = funcionario;
        }

        public IActionResult Index() {
            return View(fun.ListarFuncionarios());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
