using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Reflection.Emit;
using TaskManager.Models;
using ModelsTask = TaskManager.Models.Task;
using ModelsTaskStatus = TaskManager.Models.TaskStatus;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Data
{
    public class TaskManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ModelsTaskStatus> Statuses { get; set; }
        public DbSet<TaskPriority> Priorities { get; set; }
        public DbSet<ModelsTask> Tasks { get; set; }

        public TaskManagementContext(DbContextOptions<TaskManagementContext> options)
      : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ModelsTaskStatus>().HasData(
                new ModelsTaskStatus { Id = 1, Name = "New" },
                new ModelsTaskStatus { Id = 2, Name = "In Progress" },
                new ModelsTaskStatus { Id = 3, Name = "Completed" }
            );

            modelBuilder.Entity<TaskPriority>().HasData(
                new TaskPriority { Id = 1, Name = "Low" },
                new TaskPriority { Id = 2, Name = "Medium" },
                new TaskPriority { Id = 3, Name = "High" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
