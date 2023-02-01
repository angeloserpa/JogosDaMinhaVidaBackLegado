using JMV.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Service.Services
{
    public class TimesService
    {
        private readonly ITimesRepository _timesRepository;

        public TimesService(ITimesRepository timesRepository)
        {
            _timesRepository = timesRepository;
        }
    }
}
