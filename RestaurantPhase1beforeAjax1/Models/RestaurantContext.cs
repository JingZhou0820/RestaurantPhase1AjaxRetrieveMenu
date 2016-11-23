namespace RestaurantPhase1beforeAjax1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<menu> menus { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.menus)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Categories)
                .WithRequired(e => e.Restaurant)
                .WillCascadeOnDelete(false);
        }
    }
}
