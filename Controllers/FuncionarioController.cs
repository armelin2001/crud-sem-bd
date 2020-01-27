using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crud_sem_bd.Models;
using crud_sem_bd.Repository;

namespace crud_sem_bd.Controllers {
    public class FuncionarioController : Controller {
        private readonly RepositorioFuncionarios fun;
        public FuncionarioController(RepositorioFuncionarios funcionario) {
            fun = funcionario;
        }
        
        [HttpPost]
        public IActionResult Detalhes(Funcionario funcionario) {
            fun.Detalhes(funcionario);
            return View();
        }
        public IActionResult Detalhes(int id) {
            var funcionarioDetalhe = fun.Buscar(id);
            return View(funcionarioDetalhe);
        }
        public IActionResult Deletar(int id) {
            var deletFuncionario = fun.Buscar(id);
            fun.Excluir(deletFuncionario);
            return View("./Cadastrar");
        }
        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Funcionario funcionario) {
            fun.Adicionar(funcionario);
            return View();
        }
        [HttpPost]
        public IActionResult Alterar(Funcionario funcionario) {
            fun.Editar(funcionario);
            return View();
        }
        [HttpGet]
        public IActionResult Alterar(int id) {
            var funcio = fun.Buscar(id);
            return View(funcio);
        }


    }
}
