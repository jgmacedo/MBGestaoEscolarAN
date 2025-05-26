using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Repository.Interfaces;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class AlunoService : IAlunoService
    {
       private readonly SQLServerDbContext _context;

        public AlunoService(SQLServerDbContext context)
        {
            _context = context;
        }
    }
}
