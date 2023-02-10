using JMV.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Service.Interfaces
{
    public interface ITimeService
    { 
        public Task<Times> BuscarTime(string apelido);
        public Task<Times> BuscarTimePorId(int id);

        public Task<IEnumerable<Times>> BuscarTimes();

        public Task<Times> CriarTime(Times novoTime);
    }
}
