using Microsoft.EntityFrameworkCore;
using MosqueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MosqueManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Member> Members { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Member>(entity =>
            //{
            //    entity.Property(en => en.Id).IsRequired();
            //    entity.Property(en => en.Address).IsRequired();

            //});
            modelBuilder.Entity<MemberType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(255);
            });
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Address1).IsRequired();
            });
        }
    }
}
