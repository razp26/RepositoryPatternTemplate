using Repository.Core.Domain;
using System.Data.Entity;

namespace Repository.Persistance
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("name=DemoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Example> Examples { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DemoConfiguration());
        }
    }
}
