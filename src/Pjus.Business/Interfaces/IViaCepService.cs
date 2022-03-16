using Pjus.Business.Models;
using System.Threading.Tasks;

namespace Pjus.Business.Interfaces
{
    public interface IViaCepService
    {
        Task<Endereco> ObterEndereco(string cep);
    }
}
