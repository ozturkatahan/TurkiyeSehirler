using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TurkiyeSehirler
{
    public partial class SehirlerContext : DbContext
    {
        public SehirlerContext()
            : base("name=SehirlerContext")
        {
        }

        public virtual DbSet<Bolgeler> Bolgeler { get; set; }
        public virtual DbSet<Sehirler> Sehirler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolgeler>()
                .HasMany(e => e.Sehirler)
                .WithRequired(e => e.Bolgeler)
                .HasForeignKey(e => e.BolgeId)
                .WillCascadeOnDelete(false);
        }
    }
}
