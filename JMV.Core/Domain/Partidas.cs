using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Core.Domain
{
    public class Partidas
    {
        public int Id { get; set; }
        public int IdTimeMandante { get; set; }
        public int IdTimeVisitante { get; set; }
        public int IdCampeonato { get; set; }
        public int IdEstadio { get; set; }
        public string Resultado { get; set; }
    }
}
