using System.Data.Entity;

namespace DataLayer
{
    public class ContosoContext : DbContext
    {
        public ContosoContext()
            : base("name=ContosoContext")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(53, 0);
        }
    }
}