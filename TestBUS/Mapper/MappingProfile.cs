using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.ViewModel;

namespace TestBUS.Mapper
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
