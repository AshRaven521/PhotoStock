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
        /*[NotMapped]
        public List<Photo> Photos { get; set; }
        [NotMapped]
        public List<Text> Texts { get; set; }*/

        public Photo Photo { get; set; }
        public Text Text { get; set; }
    }
}
