using gesInscription.Models;
namespace gesInscription.Services
{
    public interface IEtudiantService
    {
        Etudiant? GetByCode(string code);
        IEnumerable<Etudiant> GetEtudiants();
    }
}