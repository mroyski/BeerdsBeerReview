using ReviewsSites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.ReviewsRepositories
{
    public class ReviewsRepository
    {
        public Dictionary<int, Reviews> reviewList = new Dictionary<int, Reviews>()
            {
                {1, new Reviews() {Id = 1, Beer = "Zombie Dust", Rating = 4.8f, Description = "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", ImgPath = "/Images/Zombiedust.png" } },
                {2, new Reviews() {Id = 2, Beer = "Hopslam", Rating = 4.6f, Description = "blah blah"} },
                {3, new Reviews() {Id = 3, Beer = "Boomsauce", Rating = 3.0f, Description = "blah blah"} }
            };

        public IEnumerable<Reviews> GetAll()
        {
            return reviewList.Values.ToList();
        }

        public object GetById(int id)
        {
            return reviewList[id];
        }
    }
}

