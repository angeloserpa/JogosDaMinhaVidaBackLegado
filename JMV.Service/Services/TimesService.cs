using JMV.Core.Domain;
using JMV.Data.Interfaces;
using JMV.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Service.Services
{
    public class TimesService : ITimeService
    {
        private readonly ITimesRepository _timesRepository;

        public TimesService(ITimesRepository timesRepository)
        {
            _timesRepository = timesRepository;
        }

        public async Task<Times> BuscarTime(string apelido)
        {
            return await _timesRepository.BuscarTime(apelido);
        }
        public async Task<Times> BuscarTimePorId(int id)
        {
            return await _timesRepository.BuscarTimePorId(id);
        }

        public async Task<IEnumerable<Times>> BuscarTimes()
        {
            return await _timesRepository.BuscarTimes();
        }

        public async Task<Times> CriarTime(Times novoTime)
        {
            return await _timesRepository.CriarTime(novoTime);
        }
    }
}
