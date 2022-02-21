namespace NoteTaker.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using Models.Notes;

    public class NoteTakerDbContext : DbContext
    {
        public NoteTakerDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlite("Data Source=appdb.db;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().ToTable("Notes");
        }

        public DbSet<Note> Notes { get; set; } = default!;
    }
}
