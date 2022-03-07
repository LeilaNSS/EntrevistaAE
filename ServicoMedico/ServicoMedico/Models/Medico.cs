using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoMedico.Models
{
    public class Medico
    {
        [Key]
        [Required]
        public int Id_Med { get; set; }
        [Required]
        public string Nome_Med { get; set; }
        [Required]
        public string Especialidade { get; set; }
        [Required]
        public string Crm { get; set; }


    }
}
