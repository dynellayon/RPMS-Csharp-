using AutoMapper;
using RPMS.Application.DTOs.Position;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Application
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Position, PositionDto>().ReverseMap();
        }
    }
}
