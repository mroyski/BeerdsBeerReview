using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public float Abv { get; set; }
        public float Rating { get; set; }
        public string Name { get; set; }
        public string Brewery { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; } 
        public virtual Category Category { get; set; }  
    }
}
