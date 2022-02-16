using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStock.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentUrl { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public DateTime CreationDate { get; set; }
        public Author Author { get; set; }
        public int Cost { get; set; }
        public int PurchaseAmount { get; set; }
    }
}
