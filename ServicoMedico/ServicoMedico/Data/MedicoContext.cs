using Microsoft.EntityFrameworkCore;
using ServicoMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoMedico.Data
{
    public class MedicoContext : DbContext
    {
        public MedicoContext(DbContextOptions<MedicoContext> opt) : base(opt)
        {

        }
        public DbSet<Consulta>  Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }
    }
}
