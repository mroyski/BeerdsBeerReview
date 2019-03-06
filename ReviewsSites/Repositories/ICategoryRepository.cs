using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSites.Models;

namespace ReviewsSites.Repositories
{
    public interface ICategoryRepository
    {
         IEnumerable<Category> GetAll();
         Category GetById(int id);
    }
}
