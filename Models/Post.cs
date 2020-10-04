using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommentApp.Models
{
    public class Post
    {
        public int  Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
