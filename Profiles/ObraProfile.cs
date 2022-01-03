using AutoMapper;
using DesafioLibrary.Data;
using DesafioLibrary.Model;

namespace DesafioLibrary.Profiles
{
    public class ObraProfile : Profile
    {
        public ObraProfile()
        {
            CreateMap<CreateObrasDto, Obras>();
            CreateMap<Obras, ReadObrasDto>();
            CreateMap<UpdateObrasDto, Obras>();
        }
    }
}
