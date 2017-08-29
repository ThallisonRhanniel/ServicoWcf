namespace ProjetoWCF.Models
{
    using System.Data.Entity;

    public partial class Dados : DbContext
    {
        public Dados()
            : base("name=Dados")
        {
        }

        public virtual DbSet<pessoas> pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pessoas>()
                .Property(e => e.valorHash)
                .IsUnicode(false);

            modelBuilder.Entity<pessoas>()
                .Property(e => e.nome)
                .IsUnicode(false);
        }
    }
}
