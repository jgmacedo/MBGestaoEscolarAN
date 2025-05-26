using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class AlunoService : IAlunoService
    {
       private readonly SQLServerDbContext _context;

        public AlunoService(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<int> AdicionarAsync(Aluno aluno)
        {
            if(aluno.DataCadastro == default)
            {
                aluno.DataCadastro = DateTime.Now;
            }
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
            return aluno.AlunoId;
        }

        public async Task<bool> AlterarAsync(Aluno aluno)
        {
            var alunoExiste = await _context.Alunos.FindAsync(aluno.AlunoId);
            if(alunoExiste == null)
            {
                return false;
            }
            aluno.DataCadastro = DateTime.Now;
            _context.Entry(alunoExiste).CurrentValues.SetValues(aluno);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if(aluno == null)
            {
                return false;
            }
            _context.Alunos.Remove(aluno);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Aluno?> ListarPorIdAsync(int id)
        {
            return await _context.Alunos
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(x => x.AlunoId == id);
        }

        public async Task<IEnumerable<Aluno>> ListarTodosAsync()
        {
            return await _context.Alunos
                                 .AsNoTracking()
                                 .OrderBy(x => x.Nome)
                                 .ToListAsync();
        }
    }
}
