using AutoMapper;
using Business.Model;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class FlightManager
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public FlightManager(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FlightModel>> ListAsync()
        {
            var entity = await _context.Flights.ToListAsync();
            return _mapper.Map<IEnumerable<FlightModel>>(entity);
        }
    }
}
