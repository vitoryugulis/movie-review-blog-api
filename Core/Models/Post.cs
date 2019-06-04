using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }   
        public string AuthorName { get; set; }
        public DateTime CreateDate { get; set; }
        public string MovieName { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}