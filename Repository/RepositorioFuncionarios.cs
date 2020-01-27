using crud_sem_bd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_sem_bd.Repository {
    public class RepositorioFuncionarios {

        private readonly List<Funcionario> _funcionarios;
        public RepositorioFuncionarios(List<Funcionario> funcionarios) {
            _funcionarios = funcionarios;
        }

        private Funcionario GerarIdFuncionario(Funcionario fun) {
            int id = 0;
            if (_funcionarios.Count != 0) {
                id = _funcionarios.LastOrDefault().Id + 1;
            }
            fun.Id = id;
            return fun;
        }
      
        public List<Funcionario> ListarFuncionarios() {
            return _funcionarios;
        }
        public Funcionario Buscar(int id) {
            return _funcionarios.FirstOrDefault(fu => fu.Id == id);
        }
        public void Adicionar(Funcionario funcionario) {
            funcionario = GerarIdFuncionario(funcionario);
            _funcionarios.Add(funcionario);
        }
        public void Excluir(Funcionario funcionario) {
            _funcionarios.Remove(funcionario);
        }
        public void Editar(Funcionario funcionario) {
            var listaFuncionario = Buscar(funcionario.Id);
            listaFuncionario.Nome = funcionario.Nome;
            listaFuncionario.Salario = funcionario.Salario;
        }
        public void Detalhes(Funcionario funcionario) {

        }
    }
}
