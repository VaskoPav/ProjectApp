using CodingTest.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.DataAccess
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectEmployeeClient>().HasKey(pe => new
            {
                pe.EmployeeId,
                pe.ProjectId
            });

            modelBuilder.Entity<ProjectEmployeeClient>().HasOne(p => p.Project).WithMany(pe => pe.ProjectEmployee).HasForeignKey(p => p.ProjectId);

            modelBuilder.Entity<ProjectEmployeeClient>().HasOne(p => p.Employee).WithMany(pe => pe.ProjectEmployee).HasForeignKey(p => p.EmployeeId);



            base.OnModelCreating(modelBuilder);

            
        }

        public DbSet<Client> Client { get; set;}
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectEmployeeClient> ProjectEmployee { get; set; }

    }
}
