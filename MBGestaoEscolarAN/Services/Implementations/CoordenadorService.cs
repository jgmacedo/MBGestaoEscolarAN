using MBGestaoEscolarAN.Data;
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
    }
}
