using ReviewsSites.Models;
using ReviewsSites.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace ReviewsSites.ReviewsRepositories
{
    public class BeerRepository : IBeerRepository
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

        public Beer GetById(int id)
        {
            return db.Beers.Single(Beer => Beer.BeerId == id);
        }
    }
}

