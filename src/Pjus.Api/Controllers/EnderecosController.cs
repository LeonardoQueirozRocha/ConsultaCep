using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pjus.Api.ViewModels;
using Pjus.Business.Interfaces;
using System.Threading.Tasks;

namespace Pjus.Api.Controllers
{
    [Route("api/[controller]")]
    public class EnderecosController : Controller
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IEnderecoService _enderecoService;
        private readonly IViaCepService _viaCepService;
        private readonly IMapper _mapper;

        public EnderecosController(IEnderecoRepository enderecoRepository, IEnderecoService enderecoService, IViaCepService viaCepService, IMapper mapper)
        {
            _enderecoRepository = enderecoRepository;
            _enderecoService = enderecoService;
            _viaCepService = viaCepService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("ObterEndereco/{cep}")]
        public async Task<ActionResult<EnderecoViewModel>> ObterEndereco(string cep)
        {
            if (string.IsNullOrEmpty(cep)) return NotFound();

            var endereco = _viaCepService.ObterEndereco(cep).Result;

            if (endereco == null) return NotFound();

            await _enderecoService.Adicionar(endereco);

            return _mapper.Map<EnderecoViewModel>(endereco);
        }
    }
}
