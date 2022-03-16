using Pjus.Business.Interfaces;
using Pjus.Business.Models;
using Pjus.Data.Context;

namespace Pjus.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }
    }
}
