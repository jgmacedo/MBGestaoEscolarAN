using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class TurmaService:ITurmaService
    {
        private readonly SQLServerDbContext _context;

        public TurmaService(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<int> AdicionarAsync(Turma turma)
        {
            _context.Turmas.Add(turma);
            await _context.SaveChangesAsync();
            return turma.TurmaId;
        }

        public async Task<bool> AlterarAsync(Turma turma)
        {
            var turmaExiste = await _context.Turmas.FindAsync(turma.TurmaId);
            if (turmaExiste == null)
            {
                return false;
            }
            _context.Entry(turmaExiste).CurrentValues.SetValues(turma);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var turma = await _context.Turmas.FindAsync(id);
            if (turma == null)
            {
                return false;
            }
            _context.Turmas.Remove(turma);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Turma?> ListarPorIdAsync(int id)
        {
            return await _context.Turmas
                                .AsNoTracking()
                                .FirstOrDefaultAsync(x => x.TurmaId == id);
        }

        public async Task<IEnumerable<Turma>> ListarTodosAsync()
        {
            return await _context.Turmas
                                .AsNoTracking()
                                .OrderBy(x => x.Nome)
                                .ToListAsync();
        }
    }
}
