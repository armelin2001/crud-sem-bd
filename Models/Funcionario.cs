using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud_sem_bd.Models {
    public class Funcionario {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "O nome deve ser maior que 3 caracteries")]
        public string Nome { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser positivo")]
        public double Salario { get; set; }
        
    }
}
