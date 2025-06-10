using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CoordenadorService:ICoordenadorService
    {
        private readonly SQLServerDbContext _context;

        public CoordenadorService(SQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<int> AdicionarAsync(Coordenador coordenador)
        {
            var coordenadorExiste = await _context.Coordenadores.FindAsync(coordenador.CPF);
            if (coordenadorExiste == null)
            {
                _context.Coordenadores.Add(coordenador);
                await _context.SaveChangesAsync();
                return coordenador.CoordenadorId;
            }
            else
            {
                throw new Exception("Coordenador já cadastrado com o CPF informado.");
            }
        }

        public async Task<bool> AlterarAsync(Coordenador coordenador)
        {
            var coordenadorExiste = await _context.Coordenadores.FindAsync(coordenador.CoordenadorId);
            if (coordenadorExiste == null)
            {
                return false;
            }
            _context.Entry(coordenadorExiste).CurrentValues.SetValues(coordenador);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var coordenador = await _context.Coordenadores.FindAsync(id);
            if (coordenador == null)
            {
                return false;
            }
            _context.Coordenadores.Remove(coordenador);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Coordenador?> ListarPorIdAsync(int id)
        {
            return await _context.Coordenadores
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(x => x.CoordenadorId == id);
        }

        public async Task<IEnumerable<Coordenador>> ListarTodosAsync()
        {
            return await _context.Coordenadores
                                 .AsNoTracking()
                                 .OrderBy(x => x.Nome)
                                 .ToListAsync();
        }
    }
}
