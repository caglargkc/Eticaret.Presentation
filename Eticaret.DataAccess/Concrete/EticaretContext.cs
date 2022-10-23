



using Eticaret.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.DataAccess.Concrete
{
    public class EticaretContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Data Source=?;Initial Catalog=?;User ID=?;Password=?");
        }
        public DbSet<User> Users {get;set;}
        public DbSet<UserToken> UserTokens {get;set; }
        public DbSet<Category> Categories {get;set; }
        public DbSet<Slider> Sliders {get;set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; } // ekle
    }
}
