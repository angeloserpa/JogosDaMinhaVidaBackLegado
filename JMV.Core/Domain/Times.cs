using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Core.Domain
{
    public class Times
    {
        public int Id { get; set; }
        public int IdEstadio { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Apelido { get; set; }
    }
}
