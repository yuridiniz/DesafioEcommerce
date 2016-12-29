using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Model
{
    public class EcommerceDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transacoes { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public EcommerceDB() : base("name=EcommerceDB")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer<EcommerceDB>(new EcommerceDBInitialize());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                   .Where(p => p.Name == p.ReflectedType.Name + "Id")
                   .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                   .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                  .Configure(p => p.HasMaxLength(255));

        }
    }
}
