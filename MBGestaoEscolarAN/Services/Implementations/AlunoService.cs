using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Repository.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class AlunoService : IAlunoService
    {
       private readonly SQLServerDbContext _context;

        public AlunoService(SQLServerDbContext context)
        {
            _context = context;
        }

        public Task<int> AdicionarAsync(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AlterarAsync(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Aluno> ListarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Aluno>> ListarTodosAsync()
        {
            
        }
    }
}
