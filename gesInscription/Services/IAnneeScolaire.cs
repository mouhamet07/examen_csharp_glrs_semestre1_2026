using gesInscription.Models;
namespace gesInscription.Services
{
    public interface IAnneeScolaireService
    {
        AnneeScolaire? GetByCode(string code);
        IEnumerable<AnneeScolaire> GetAnneeScolaires();
    }
}