using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAPI.Infrastructure.Context
{
    public class UserContext : DbContext
    {
        public UserContext() : base() { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Map(m =>
            {
                m.Properties(p => new
                {
                    p.UserID,
                    p.Username,
                    p.Password
                });
                m.ToTable("Users");
            });

            modelBuilder.Entity<User>().HasKey<int>(u => u.UserID);

            modelBuilder.Entity<User>()
                .Property(p => p.Username)
                .IsConcurrencyToken()
                .HasMaxLength(25)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(p => p.Password)
                .HasMaxLength(25)
                .IsRequired();
        }
    }
}
