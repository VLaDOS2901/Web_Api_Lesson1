using BusinessLogic.DTOs;
using Monitor = Data.Models.Monitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Monitor, MonitorDto>()
                .ForMember(d => d.MatrixId, opt => opt.MapFrom(s => s.MatrixId))
                .ForMember(d => d.MatrixName, opt => opt.MapFrom(s => s.Matrix.Name));

            CreateMap<MonitorDto, Monitor>()
                .ForMember(d => d.MatrixId, opt => opt.MapFrom(s => s.MatrixId));

            CreateMap<UserDto, IdentityUser>()
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => s.Email))
                .ForMember(d => d.Id, opt => opt.Ignore());
        }
    }
}
