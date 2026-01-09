using gesInscription.Models;
using Microsoft.EntityFrameworkCore;

namespace gesInscription.Data
{
    public class GesInscriptionDbContext : DbContext
    {
        public DbSet<AnneeScolaire> AnneeScolaires { get; set; } = null!;
        public DbSet<Classe> Classes { get; set; } = null!;
        public DbSet<Etudiant> Etudiants { get; set; } = null!;
        public DbSet<Inscription> Inscriptions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnneeScolaire>()
                .ToTable("AnneeScolaires");
            modelBuilder.Entity<AnneeScolaire>()
                .HasKey(a => a.Id);
            modelBuilder.Entity<AnneeScolaire>()
                .Property(a => a.Code)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<AnneeScolaire>()
                .Property(a => a.Libelle)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<AnneeScolaire>()
                .Property(a => a.StatutAnne)
                .IsRequired();

            modelBuilder.Entity<Classe>()
                .ToTable("Classes");
            modelBuilder.Entity<Classe>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Classe>()
                .Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Classe>()
                .Property(c => c.Libelle)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Etudiant>()
                .ToTable("Etudiants");
            modelBuilder.Entity<Etudiant>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Etudiant>()
                .Property(e => e.Matricule)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Etudiant>()
                .Property(e => e.Prenom)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Etudiant>()
                .Property(e => e.Nom)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Inscription>()
                .ToTable("Inscriptions");
            modelBuilder.Entity<Inscription>()
                .HasKey(i => i.Id);
            modelBuilder.Entity<Inscription>()
                .Property(i => i.Date)
                .IsRequired();
            modelBuilder.Entity<Inscription>()
                .Property(i => i.Montant)
                .IsRequired();

            modelBuilder.Entity<Inscription>()
                .Property(i => i.EtudiantId)
                .IsRequired();
            modelBuilder.Entity<Inscription>()
                .Property(i => i.ClasseId)
                .IsRequired();
            modelBuilder.Entity<Inscription>()
                .Property(i => i.AnneeScolaireId)
                .IsRequired();
            //FK
            modelBuilder.Entity<Inscription>()
                .HasOne(i => i.EtudiantInscrit)
                .WithMany()
                .HasForeignKey(i => i.EtudiantId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Inscription>()
                .HasOne(i => i.ClasseInscrit)
                .WithMany()
                .HasForeignKey(i => i.ClasseId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Inscription>()
                .HasOne(i => i.AnneeScolaireInscrit)
                .WithMany()
                .HasForeignKey(i => i.AnneeScolaireId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Database=gesInscriptionDb;Username=postgres;Password=Mouhamed-1234");
        }
    }
}
