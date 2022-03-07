using Microsoft.AspNetCore.Mvc;
using ServicoMedico.Data;
using ServicoMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoMedico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        private MedicoContext _context;
        public PacienteController(MedicoContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AdicionaPaciente([FromBody] Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(VerConsultasPaci), new { Id_Paci = paciente.Id_Paci }, paciente);
        }
        [HttpGet]
        public IEnumerable<Paciente> VerConsultas()
        {
            return _context.Pacientes;
        }

        [HttpGet("{Id_Paci}")]
        public IActionResult VerConsultasPaci(int id_paci)
        {

            var paciente = _context.Pacientes.Where(paciente => paciente.Id_Paci == id_paci);

            if (paciente != null)
            {
                return Ok(paciente);
            }
            return NotFound();
        }
    }
}
