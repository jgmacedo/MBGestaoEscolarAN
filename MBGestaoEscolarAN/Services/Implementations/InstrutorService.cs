using MBGestaoEscolarAN.Data;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class InstrutorService
    {
        private readonly SQLServerDbContext _context;

        public InstrutorService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
