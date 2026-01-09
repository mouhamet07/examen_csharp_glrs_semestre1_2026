using gesInscription.Models;
namespace gesInscription.Services
{
    public interface IInscriptionService
    {
        void CreateInscription(Inscription inscription);
        IEnumerable<Inscription> GetByClasse(string codeClasse);
    }
}