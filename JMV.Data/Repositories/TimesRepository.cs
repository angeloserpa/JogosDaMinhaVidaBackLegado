using JMV.Core.Domain;
using JMV.Data.Context;
using JMV.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMV.Data.Repository
{
    public class TimesRepository : ITimesRepository

    {
        private readonly JmvContext _context;

        public TimesRepository(JmvContext context)
        {
            _context = context;
        }
        public async Task<Times> BuscarTime(string apelido)
        {
            var query = await _context.Times.FirstOrDefaultAsync(t => t.Apelido == apelido);

            return query;
        }

        public async Task<Times> BuscarTimePorId(int id)
        {
            var query = await _context.Times.Where(t => t.Id == id).FirstOrDefaultAsync();

            return query;
        }

        public async Task<IEnumerable<Times>> BuscarTimes()
        {
            return await _context.Times.AsNoTracking().ToListAsync();
        }

        public async Task<Times> CriarTime(Times novoTime)
        {
            _context.Times.Add(novoTime);
            await _context.SaveChangesAsync();

            return await _context.Times.FirstOrDefaultAsync(t => t.Id == novoTime.Id);
        }

    }
}
