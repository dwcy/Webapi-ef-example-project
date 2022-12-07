using ITHS.Webapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITHS.Webapi.Persistance
{
    public class ITHSDatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ITHSDatabaseContext() : base()
        {
        }
        
        public ITHSDatabaseContext(DbContextOptions<ITHSDatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=SqlLight.db");

            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            CreatePersonsModel(modelBuilder);
            CreateRolesModel(modelBuilder);
        }

   //exempel
        //private void CreatePersonsModel(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //        entity.Property(e => e.FirstName).HasMaxLength(50).IsRequired();
        //        entity.Property(e => e.LastName).HasMaxLength(50).IsRequired();
        //        entity.Property(e => e.RoleId).IsRequired();
        //        entity.HasOne(e => e.Role).WithMany(e => e.Persons).HasForeignKey(e => e.RoleId);
        //    });
        //}

        private void CreatePersonsModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasIndex(person => person.FirstName)
                .IsUnique(false);

            modelBuilder.Entity<Person>()
                .HasOne<Role>(person => person.Role);

        }

        private void CreateRolesModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasIndex(role => role.RoleName)
                .IsUnique(true); 
        }
    }
}
