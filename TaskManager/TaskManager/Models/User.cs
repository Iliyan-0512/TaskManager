using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace TaskManager.Models
{
    public class User: IdentityUser
    {
        
        
        public ICollection<Task> Tasks { get; set; }
    }
}
