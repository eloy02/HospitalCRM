using HospitalCRM.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalCRM.Backend.Core.Database;

public class DataContext : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorPosition> DoctorsPositions { get; set; }
    public DbSet<Pacient> Pacients { get; set; }
    public DbSet<PacientDocument> PacientDocuments { get; set; }
    public DbSet<PacientParent> PacientParents { get; set; }
    public DbSet<PacientVisit> PacientVisits { get; set; }
    public DbSet<User> Users { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(e =>
        {
            e.ToTable(nameof(Doctors));

            e.HasKey(x => x.Id);

            e.HasOne(x => x.Position)
                .WithMany(p => p.Doctors);
        });

        modelBuilder.Entity<DoctorPosition>(e =>
        {
            e.ToTable(nameof(DoctorsPositions));

            e.HasKey(x => x.Id);
        });

        modelBuilder.Entity<Pacient>(e =>
        {
            e.ToTable(nameof(Pacients));

            e.HasKey(x => x.Id);

            e.HasMany(x => x.Parents)
                .WithOne(p => p.Pacient);

            e.HasMany(x => x.Documents)
                .WithOne(d => d.Pacient);
        });

        modelBuilder.Entity<PacientDocument>(e =>
        {
            e.ToTable(nameof(PacientDocument));

            e.HasKey(x => x.Id);
        });

        modelBuilder.Entity<PacientParent>(e =>
        {
            e.ToTable(nameof(PacientParents));

            e.HasKey(x => x.Id);
        });

        modelBuilder.Entity<PacientVisit>(e =>
        {
            e.ToTable(nameof(PacientVisits));

            e.HasKey(x => x.Id);

            e.HasOne(x => x.Pacient)
                .WithMany(x => x.Visits);

            e.HasOne(x => x.Doctor)
                .WithMany(x => x.PacientVisits);
        });

        modelBuilder.Entity<User>(e =>
        {
            e.ToTable(nameof(Users));

            e.HasKey(x => x.Id);
        });
    }
}