using JMV.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Data.Context
{
    public class JmvContext : DbContext
    {

        public DbSet<Campeonatos> Campeonatos { get; set; }
        public DbSet<Estadios> Estadios { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Partidas> Partidas { get; set; }
        public DbSet<Tipos> Tipos { get; set; }
        public DbSet<Modalidades> Modalidades { get; set; }

        public JmvContext(DbContextOptions options) : base(options)
        {

        }
    }
}
