using AutoMapper;
using Pjus.App.ViewModels;
using Pjus.Business.Models;

namespace Pjus.App.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
