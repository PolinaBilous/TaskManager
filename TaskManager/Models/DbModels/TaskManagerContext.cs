using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DbModels
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<List>().HasKey(l => l.Id);
            modelBuilder.Entity<Task>().HasKey(t => t.Id);
            modelBuilder.Entity<Status>().HasKey(s => s.Id);

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<List>().ToTable("List");
            modelBuilder.Entity<Task>().ToTable("Task");
            modelBuilder.Entity<Status>().ToTable("Status");

            base.OnModelCreating(modelBuilder);
        }
    }
}
