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
    public class ConsultaController : ControllerBase
    {
        private MedicoContext _context;

        public ConsultaController(MedicoContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AdicionaConsulta([FromBody] Consulta consulta)
        {
            var consultasAgendadas = _context.Consultas.Where(ag => ag.Data == consulta.Data && ag.Id_Med == consulta.Id_Med);
            if (consultasAgendadas.Count() > 0)
            {
                return NotFound("Horário Já cadastrado.Por favor insera outro horário.");
            }
            else
            {
                
                _context.Consultas.Add(consulta);
                _context.SaveChanges();
                return CreatedAtAction(nameof(VerConsultas), new { Id_Med = consulta.Id_Med }, consulta);
            }
        }
       
        [HttpGet]
        public IEnumerable<Consulta> VerConsultas()
        {
            return _context.Consultas;
        }
     
    }
}