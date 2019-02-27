using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Repositories
{
    public class CategoryRepository
    {
        ReviewsContext db;

        public CategoryRepository(ReviewsContext db)
        {
            this.db = db;
        }

        //public object GetById(int id)
        //{
        //    return db.Review.Single(Reviews => Reviews.Id == id);
        //}
    }
}
