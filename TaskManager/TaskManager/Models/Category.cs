using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace TaskManager.Models


{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
