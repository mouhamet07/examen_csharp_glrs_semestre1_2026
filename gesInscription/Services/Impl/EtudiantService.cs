using gesInscription.Data;
using gesInscription.Models;

namespace gesInscription.Services
{
    public class EtudiantService : IEtudiantService
    {
        private readonly AppDbContext _context;
        public EtudiantService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Etudiant> GetEtudiants()
        {
            return _context.Etudiants.ToList();
        }
        public Etudiant? GetByCode(string mat)
        {
            return _context.Etudiants
                .FirstOrDefault(e => e.Matricule == mat);
        }
    }
}
