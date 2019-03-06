using ReviewsSites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ReviewsContext db;

        public CategoryRepository(ReviewsContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(Category => Category.CategoryId == id);
        }


    }
}
