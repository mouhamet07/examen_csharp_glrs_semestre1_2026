using gesInscription.Data;
using gesInscription.Models;

namespace gesInscription.Services
{
    public class AnneeScolaireService : IAnneeScolaireService
    {
        private readonly AppDbContext _context;

        public AnneeScolaireService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<AnneeScolaire> GetAnneeScolaires()
        {
            return _context.AnneeScolaires.ToList();
        }
        public AnneeScolaire? GetByCode(string code)
        {
            return _context.AnneeScolaires
                .FirstOrDefault(a => a.Code == code);
        }
    }
}
