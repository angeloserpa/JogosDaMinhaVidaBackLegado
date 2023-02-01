using JMV.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Data.Interfaces
{
    public interface ITimesRepository
    {
        Task<Times> BuscarTime(string apelido);
        Task<Times> BuscarTimePorId(int id);
        Task<IEnumerable<Times>> BuscarTimes();
        Task<Times> CriarTime(Times novoTime);
    }
}
