using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _826488CW2.Models
{
    public class Customer : IdentityUser
    {
        [Required, ScaffoldColumn(false), Key]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress), Required]
        public string Email{ get; set; }
        [MinLength(2), MaxLength(60)]
        public string Name { get; set; }
        //ToDo: Add data annotations
        public DateTime Birthdate { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
