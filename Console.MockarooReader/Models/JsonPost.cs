using System;
using System.Collections.Generic;

namespace ConsoleApp.MockarooReader
{
    public class JsonComment
    {
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreateDate { get; set; }
    }


    public class JsonPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreateDate { get; set; }
        public string MovieName { get; set; }
        public List<JsonComment> Comments { get; set; }
    }
}