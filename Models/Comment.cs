using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommentApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string CommentDes { get; set; }
        public DateTime CreateDate { get; set; }
        public int CommentCount { get; set; }
        public virtual Post Post { get; set; }
        public int PostID { get; set; }
    }
}
