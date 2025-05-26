using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Services.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CursoService:ICursoService
    {
        private readonly SQLServerDbContext _context;

        public CursoService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
