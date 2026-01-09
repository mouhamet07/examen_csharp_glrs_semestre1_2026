using gesInscription.Data;
using gesInscription.Models;
using Microsoft.EntityFrameworkCore;

namespace gesInscription.Services
{
    public class InscriptionService : IInscriptionService
    {
        private readonly AppDbContext _context;

        public InscriptionService(AppDbContext context)
        {
            _context = context;
        }
        public void CreateInscription(Inscription inscription)
        {
            _context.Inscriptions.Add(inscription);
            _context.SaveChanges();
        }
        public IEnumerable<Inscription> GetByClasse(string codeClasse)
        {
            return _context.Inscriptions
                .Include(i => i.EtudiantInscrit)
                .Include(i => i.ClasseInscrit)
                .Include(i => i.AnneeScolaireInscrit)
                .Where(i => i.ClasseInscrit.Code == codeClasse)
                .ToList();
        }
    }
}
