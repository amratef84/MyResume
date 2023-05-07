using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Experience>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Skills>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Hobbies>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Address>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Languages>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Education>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Certificates>().Property(x => x.Id).HasDefaultValueSql("NEWID()");


            modelBuilder.Entity<Profile>().Navigation(e => e.Address).AutoInclude();
            modelBuilder.Entity<Profile>().Navigation(e => e.Experience).AutoInclude();
        }
     
        public  DbSet<Profile> Profile { get; set; }
        public  DbSet<Experience> Experience { get; set; }
        public  DbSet<Address> Address { get; set; }
        public  DbSet<Hobbies> Hobbies { get; set; }
        public  DbSet<Skills> Skills { get; set; }
        public  DbSet<Languages> Languages { get; set; }
        public  DbSet<Education> Education { get; set; }
        public  DbSet<Certificates> Certificates { get; set; }


    }
}
