using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Core.Domain
{
    public class Campeonatos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Organizador { get; set; }

        public int IdModalidade { get; set; }
        public Modalidades Modalidade { get; set; }
        public int IdTipo { get; set; }
        public Tipos Tipo { get; set; }

    }
}
