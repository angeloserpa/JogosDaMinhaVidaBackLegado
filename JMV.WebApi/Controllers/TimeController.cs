using JMV.Core.Domain;
using JMV.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JMV.WebApi.Controllers
{
    [ApiController]
    [Route("times")]
    public class TimeController
    {
        private readonly ITimeService _timeService;

        public TimeController(ITimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpPost("Inserir-Time")]
        public async Task<Times> CriarTime([FromBody] Times novoTime)
        {
            return await _timeService.CriarTime(novoTime);
        }

        [HttpGet("{apelido}")]
        public async Task<Times> BuscarTime(string apelido)
        {
            return await _timeService.BuscarTime(apelido);
        }

        [HttpGet("{id:int}")]
        public async Task<Times> BuscarTimePorId(int id)
        {
            return await _timeService.BuscarTimePorId(id);
        }

        [HttpGet]
        public async Task<IEnumerable<Times>> BuscarTimes()
        {
            return await _timeService.BuscarTimes();
        }
    }
}
