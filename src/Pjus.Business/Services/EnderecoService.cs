using Pjus.Business.Interfaces;
using Pjus.Business.Models;
using System.Threading.Tasks;

namespace Pjus.Business.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task<bool> Adicionar(Endereco endereco)
        {
            await _enderecoRepository.Adicionar(endereco);
            return true;
        }

        public void Dispose()
        {
            _enderecoRepository?.Dispose();
        }
    }
}
