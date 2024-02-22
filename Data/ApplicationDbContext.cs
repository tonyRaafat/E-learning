using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learing.Models;
using Microsoft.EntityFrameworkCore;

namespace E_learing.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

        }
        public DbSet<CourseCategory> CourseCategory {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseCategory>().HasData(
                new CourseCategory { Id=1, Name="Back-end"},
                new CourseCategory { Id=2, Name="Front-end"},
                new CourseCategory { Id=3, Name="FullStack"}

            );
        }

    }
}