using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Repository.Interfaces;

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
            var coordenadorExiste = await _context.Coordenadores.FindAsync(coordenador.Cpf);
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
            var coordenadorExiste = await _context.Coordenadores.FindAsync(coordenador.Cpf);
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

        public Task<Coordenador> ListarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Coordenador>> ListarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
