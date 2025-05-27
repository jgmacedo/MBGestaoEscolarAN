using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CursoService:ICursoService
    {
        private readonly SQLServerDbContext _context;

        public CursoService(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<int> AdicionarAsync(Curso curso)
        {
            var cursoExiste = await _context.Cursos.FindAsync(curso.Nome);
            if (cursoExiste == null)
            {
                _context.Cursos.Add(curso);
                await _context.SaveChangesAsync();
                return curso.CursoID;
            }
            else
            {
                throw new Exception("Curso com esse nome já existe");
            }
        }

        public async Task<bool> AlterarAsync(Curso curso)
        {
            var cursoExiste = await _context.Cursos.FindAsync(curso.CursoID);
            if (cursoExiste == null)
            {
                return false;
            }
            _context.Entry(cursoExiste).CurrentValues.SetValues(curso);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return false;
            }
            _context.Cursos.Remove(curso);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Curso?> ListarPorIdAsync(int id)
        {
            return await _context.Cursos
                                    .AsNoTracking().FirstOrDefaultAsync(x => x.CursoID == id);
        }

        public async Task<IEnumerable<Curso>> ListarTodosAsync()
        {
            return await _context.Cursos
                                 .AsNoTracking()
                                 .OrderBy(x => x.Nome)
                                 .ToListAsync();
        }
    }
}
