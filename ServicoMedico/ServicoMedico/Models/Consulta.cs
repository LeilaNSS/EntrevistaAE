using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoMedico.Models
{
    public class Consulta
    {
        [Key]
        [Required]
        public int Ìd_Consulta { get; set; }
        [Required]
        public int Id_Med { get; set; }
        [ForeignKey("Id_Med")]
        [Required]
        public int Id_Paci { get; set; }
        [ForeignKey("Id_Paci")]
        [Required]
        public string Nome_Med { get; set; }
        [ForeignKey("Nome_Med")]
        [Required]
        public string Nome_Paci { get; set; }
        [ForeignKey("Nome_Paci")]
        [Required]
        public string Local { get; set; }
        [Required]
        public string Especialidade { get; set; }
        [ForeignKey("Especialidade")]
        [Required]
        public DateTime Data { get; set; }
    }
}
