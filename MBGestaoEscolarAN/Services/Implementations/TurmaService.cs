using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class TurmaService
    {
        private readonly SQLServerDbContext _context;

        public TurmaService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
