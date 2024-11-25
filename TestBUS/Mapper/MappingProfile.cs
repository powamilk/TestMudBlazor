using AutoMapper;
using BUS.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserVM, UserUpdateVM>().ReverseMap();
            CreateMap<UserVM, UserCreateVM>().ReverseMap();
        }
    }
}
