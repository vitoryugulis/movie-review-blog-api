using System;
using System.Collections.Generic;

namespace API.DTOS
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }   
        public string AuthorName { get; set; }
        public DateTime CreateDate { get; set; }
        public string MovieName { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}