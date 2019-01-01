using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _826488CW2.Models
{
    public class Comment
{
        [Key, ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(60)]
        public string Content { get; set; }
    }
}
