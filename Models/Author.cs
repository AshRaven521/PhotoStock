using System;

namespace PhotoStock.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public short Age { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
