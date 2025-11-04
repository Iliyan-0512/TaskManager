using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
