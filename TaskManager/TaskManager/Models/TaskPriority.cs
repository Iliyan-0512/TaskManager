using System.ComponentModel.DataAnnotations;
namespace TaskManager.Models
{
    public class TaskPriority
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
