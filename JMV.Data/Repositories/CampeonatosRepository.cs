using JMV.Core.Domain;
using JMV.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Data.Repository
{
    public class CampeonatosRepository
    {
        private readonly JmvContext _context;

        public CampeonatosRepository(JmvContext context)
        {
            _context = context;
        }
    }
}
