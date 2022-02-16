﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStock.Models
{
    public class Text
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Demension { get; set; }
        public DateTime CreationDate { get; set; }
        public int Cost { get; set; }
        public Author Author { get; set; }
        public int PurchaseAmount { get; set; }
    }
}
