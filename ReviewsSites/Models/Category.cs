using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Models
{
    public class Category
    {
        public string Style { get; set; }

        public int ReviewsId { get; set; }
        public Reviews Reviews { get; set; }

    }
    
}
