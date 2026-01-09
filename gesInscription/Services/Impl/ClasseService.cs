using gesInscription.Data;
using gesInscription.Models;

namespace gesInscription.Services
{
    public class ClasseService : IClasseService
    {
        private readonly AppDbContext _context;

        public ClasseService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Classe> GetClasses()
        {
            return _context.Classes.ToList();
        }

        public Classe? GetByCode(string code)
        {
            return _context.Classes
                .FirstOrDefault(c => c.Code == code);
        }
    }
}
