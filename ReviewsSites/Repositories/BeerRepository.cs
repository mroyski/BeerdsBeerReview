using ReviewsSites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.ReviewsRepositories
{
    public class BeerRepository
    {
        ReviewsContext db;

        public BeerRepository(ReviewsContext db)
        {
            this.db = db;
        }

        public IEnumerable<Beer> GetAll()
        {
            return db.Beers.ToList();
        }

        public object GetById(int id)
        {
            return db.Beers.Single(Beer => Beer.BeerId == id);
        }
    }
}

