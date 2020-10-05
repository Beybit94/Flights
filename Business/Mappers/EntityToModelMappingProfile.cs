using AutoMapper;
using Business.Model;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers
{
    public class EntityToModelMappingProfile: Profile
    {
        public override string ProfileName => "EntityToModelMappingProfile";

        public EntityToModelMappingProfile()
        {
            CreateMap<Flight, FlightModel>();
            CreateMap<Customer, CustomerModel>();
        }
    }
}
