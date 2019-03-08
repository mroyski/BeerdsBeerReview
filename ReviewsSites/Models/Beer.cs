using System.Collections.Generic;


namespace ReviewsSites.Models
{
    public class Beer
    {
        public int BeerId { get; set; }
        public float Abv { get; set; }
        public float Rating { get; set; }
        public string Name { get; set; }
        public string Brewery { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }

        public int CategoryId { get; set; }

        public virtual IEnumerable<UserReview> UserReviews { get; set; }
    }
}
