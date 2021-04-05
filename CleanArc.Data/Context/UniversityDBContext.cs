using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;
namespace CleanArc.Data.Context
{
     public class UniversityDBContext : DbContext
    {


        public UniversityDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
