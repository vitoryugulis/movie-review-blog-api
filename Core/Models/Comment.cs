using System;

namespace Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int PostId { get; set; }
    }
    
}