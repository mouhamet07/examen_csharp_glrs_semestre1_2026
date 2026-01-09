using gesInscription.Models;
namespace gesInscription.Services
{
    public interface IClasseService
    {
        Classe? GetByCode(string code);
        IEnumerable<Classe> GetClasses();
    }
}