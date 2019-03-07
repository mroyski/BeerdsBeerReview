using System.Collections.Generic;


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
