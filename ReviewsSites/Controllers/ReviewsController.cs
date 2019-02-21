using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Controllers
{
    public class ReviewsController : Controller
    {
  
        public ViewResult Index()
        {
            return View();
        }

    }
}
