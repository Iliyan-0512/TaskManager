using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System;
namespace TaskManager.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

       
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

       
        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public TaskStatus Status { get; set; }

       
        [ForeignKey("Priority")]
        public int PriorityId { get; set; }
        public TaskPriority Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
