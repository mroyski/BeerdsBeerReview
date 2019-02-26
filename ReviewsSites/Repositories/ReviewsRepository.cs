using ReviewsSites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.ReviewsRepositories
{
    public class ReviewsRepository
    {
        ReviewsContext db;

        public ReviewsRepository(ReviewsContext db)
        {
            this.db = db;
        }
        public IEnumerable<Reviews> GetAll()
        {
            return db.Review.ToList();
        }

        public object GetById(int id)
        {
            return db.Review.Single(Reviews => Reviews.Id == id);
        }
    }
}

