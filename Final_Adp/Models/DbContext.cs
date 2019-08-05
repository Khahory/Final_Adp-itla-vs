namespace Final_Adp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContext : DbContext
    {
        public DbContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Profesionales> Profesionales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profesionales>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesionales>()
                .Property(e => e.Profesion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesionales>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
