using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository catRepo;
        public CategoryController(CategoryRepository catRepo)
        {
            this.catRepo = catRepo;
        }

        public ViewResult Index()
        {
            var model = catRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = catRepo.GetById(id);
            return View(model);
        }
    }
}
