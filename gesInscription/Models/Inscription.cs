namespace gesInscription.Models
{
    public class Inscription
    {
        public int Id {get; set;}
        public DateTime Date {get; set;}
        public decimal Montant {get; set;}
        public Etudiant EtudiantInscrit {get; set;}
        public Classe ClasseInscrit {get; set;}
        public AnneeScolaire AnneeScolaireInscrit {get; set;}
        public int EtudiantId {get; set;}
        public int ClasseId {get; set;}
        public int AnneeScolaireId {get; set;}
        public Inscription()
        {
            Date = DateTime.Now();
        }
    }
} 