using System;

namespace API.DTOS
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int PostId { get; set; }
    }
}