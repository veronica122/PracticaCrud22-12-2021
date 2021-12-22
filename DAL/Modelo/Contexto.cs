using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}
