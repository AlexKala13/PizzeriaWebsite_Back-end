using AutoMapper;
using ReactPizzeriaAPI.DTOs.Pizza;
using ReactPizzeriaAPI.Model;

namespace ReactPizzeriaAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pizza, GetPizzaDTO>().ReverseMap();
            CreateMap<Pizza, GetPizzasDTO>().ReverseMap();
        }
    }
}
