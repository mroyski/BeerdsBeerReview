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
                {1, new Reviews() {Id = 1, Beer = "Zombie Dust"} },
                {2, new Reviews() {Id = 2, Beer = "Hopslam"} },
                {3, new Reviews() {Id = 3, Beer = "Boomsauce" } }
            };

        public IEnumerable<Reviews> GetAll()
        {
            return reviewList.Values.ToList();
        }

    }
}

