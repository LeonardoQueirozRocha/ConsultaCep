using AutoMapper;
using Pjus.Api.ViewModels;
using Pjus.Business.Models;

namespace Pjus.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
