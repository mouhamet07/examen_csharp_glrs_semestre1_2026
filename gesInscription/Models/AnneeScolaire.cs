namespace gesInscription.Models
{
    public enum Statut
    {
        EN_COURS,
        CLOTURE
    }
    public class AnneeScolaire
    {
        public int Id {get; set;}
        public string Code {get; set;}
        public string Libelle {get; set;}
        public Statut StatutAnne {get; set;}
    }
}