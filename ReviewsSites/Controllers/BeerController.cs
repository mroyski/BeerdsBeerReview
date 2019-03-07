using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Repositories;


namespace ReviewsSites.Controllers
{
    public class BeerController : Controller
    {
        IBeerRepository beerRepo;
        public BeerController(IBeerRepository beerRepo)
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
