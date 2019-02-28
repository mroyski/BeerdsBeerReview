using Microsoft.AspNetCore.Mvc;
using ReviewsSites.ReviewsRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Controllers
{
    public class BeerController : Controller
    {
        BeerRepository beerRepo;
        public BeerController(BeerRepository beerRepo)
        {
            this.beerRepo = beerRepo;
        }

        public ViewResult Index()
        {
            var model = beerRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = beerRepo.GetById(id);
            return View(model);
        }


    }
}
