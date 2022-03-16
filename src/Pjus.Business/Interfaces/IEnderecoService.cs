using Pjus.Business.Models;
using System;
using System.Threading.Tasks;

namespace Pjus.Business.Interfaces
{
    public interface IEnderecoService : IDisposable
    {
        Task<bool> Adicionar(Endereco endereco);
    }
}
