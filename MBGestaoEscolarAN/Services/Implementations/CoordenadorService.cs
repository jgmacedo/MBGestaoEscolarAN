using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CoordenadorService
    {
        private readonly SQLServerDbContext _context;

        public CoordenadorService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
