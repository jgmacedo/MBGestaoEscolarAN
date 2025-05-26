using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class CursoService
    {
        private readonly SQLServerDbContext _context;

        public CursoService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
