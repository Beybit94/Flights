using AutoMapper;
using Business.Model;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers
{
    public class ModelToEntityMappingProfile:Profile
    {
        public override string ProfileName => "ModelToEntityMappingProfile";
        public ModelToEntityMappingProfile()
        {
            CreateMap<FlightModel,Flight>();
            CreateMap<CustomerModel,Customer>();
        }
    }
}
