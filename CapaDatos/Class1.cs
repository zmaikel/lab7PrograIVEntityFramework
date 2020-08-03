using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CapaDatos.Entidades;

namespace CapaDatos
{
    public class Class1 : DbContext
    {
        public Class1() : base("name=LabVPrograIV")
        {

        }

        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
    }
}
