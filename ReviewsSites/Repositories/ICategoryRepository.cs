using System.Collections.Generic;
using ReviewsSites.Models;

namespace ReviewsSites.Repositories
{
    public interface ICategoryRepository
    {
         IEnumerable<Category> GetAll();
         Category GetById(int id);
    }
}
