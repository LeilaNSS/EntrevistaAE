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
    public class MedicoController : ControllerBase
    {
        private MedicoContext _context;
        public MedicoController(MedicoContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AdicionaMed([FromBody] Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();
                return CreatedAtAction(nameof(VerConsultaPorMed), new { Id_Med = medico.Id_Med }, medico);
            
        }
        [HttpGet]
        public IEnumerable<Medico> VerConsultas()
        {
            return _context.Medicos;
        }
        [HttpGet("{Id_Med}")]
        public IActionResult VerConsultaPorMed(int id_med)
        {

            var consulta = _context.Consultas.Where(consulta => consulta.Id_Med == id_med);

            if (consulta != null)
            {
                return Ok(consulta);
            }
            return NotFound();
        }
    }
}
