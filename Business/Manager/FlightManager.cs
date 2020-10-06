using AutoMapper;
using Business.Model;
using Data;
using Data.Entity;
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

        public IEnumerable<FlightModel> List()
        {
            var entity = _context.Flights.ToList();
            return _mapper.Map<IEnumerable<FlightModel>>(entity);
        }

        public FlightModel Create(FlightModel model)
        {
            var entity = _mapper.Map<Flight>(model);
            _context.Flights.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<FlightModel>(entity);
        }

        public FlightModel Edit(FlightModel model)
        {
            var entity = _mapper.Map<Flight>(model);
            _context.Flights.Update(entity);
            _context.SaveChanges();

            return _mapper.Map<FlightModel>(entity);
        }

        public FlightModel Put(FlightModel model)
        {
            var entity = _context.Flights.FirstOrDefault(m => m.ID == model.ID);
            entity.Delay = model.Delay;
            _context.Flights.Update(entity);
            _context.SaveChanges();

            return _mapper.Map<FlightModel>(entity);
        }

        public void Delete(long Id)
        {
            var entity = _context.Flights.FirstOrDefault(m=>m.ID == Id);
            if (entity != null)
            {
                _context.Flights.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
