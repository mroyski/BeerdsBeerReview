using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Style { get; set;}
        public string ImgPath { get; set; }
        public string DetailDescription { get; set; }

        public virtual IEnumerable<Beer> Beers { get; set; }
    }

}
