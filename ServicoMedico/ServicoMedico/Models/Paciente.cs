using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoMedico.Models
{
    public class Paciente
    {
        [Key]
        [Required]
        public int Id_Paci { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Nome_Paci { get; set; }
        [Required]
        public string Contato { get; set; }

    }
}
