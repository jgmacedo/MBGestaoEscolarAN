using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Services.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class InstrutorService :IInstrutorService
    {
        private readonly SQLServerDbContext _context;

        public InstrutorService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
