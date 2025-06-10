using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class InstrutorService :IInstrutorService
    {
        private readonly SQLServerDbContext _context;

        public InstrutorService(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<int> AdicionarAsync(Instrutor instrutor)
        {
            var instrutorExiste = await _context.Instrutores.FindAsync(instrutor.CPF);
            if (instrutorExiste == null)
            {
                _context.Instrutores.Add(instrutor);
                await _context.SaveChangesAsync();
                return instrutor.InstrutorId;
            }
            else
            {
                throw new Exception("Instrutor já cadastrado com o CPF informado.");
            }
        }

        public async Task<bool> AlterarAsync(Instrutor instrutor)
        {
            var instrutorExiste = await _context.Instrutores.FindAsync(instrutor.InstrutorId);
            if (instrutorExiste == null)
            {
                return false;
            }
            _context.Entry(instrutorExiste).CurrentValues.SetValues(instrutor);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var instrutor = await _context.Instrutores.FindAsync(id);
            if (instrutor == null)
            {
                return false;
            }
            _context.Instrutores.Remove(instrutor);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Instrutor?> ListarPorIdAsync(int id)
        {
            return await _context.Instrutores
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(x => x.InstrutorId == id);
        }

        public async Task<IEnumerable<Instrutor>> ListarTodosAsync()
        {
            return await _context.Instrutores
                                 .AsNoTracking()
                                 .OrderBy(x => x.Nome)
                                 .ToListAsync();
        }
    }
}
