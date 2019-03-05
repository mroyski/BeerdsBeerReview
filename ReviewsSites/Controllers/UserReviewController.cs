using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Models;
using ReviewsSites.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSites.Controllers
{
    public class UserReviewController : Controller
    {
        UserReviewRepository userReviewRepo;

        public UserReviewController(UserReviewRepository userReviewRepo)
        {
            this.userReviewRepo = userReviewRepo;
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            var newUserReview = new UserReview()
            {
                BeerId = id
            };
            return View(newUserReview);
        }

        [HttpPost]
        public ActionResult Create(UserReview userReview)
        {
            userReviewRepo.Create(userReview);
            return RedirectToAction("../Beer/Details/" + userReview.BeerId);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = userReviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(UserReview userReview)
        {
            userReviewRepo.Delete(userReview);
            return RedirectToAction("../Beer/Index");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = userReviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(UserReview userReview)
        {
            userReviewRepo.Edit(userReview);
            return RedirectToAction("../Beer/Details/" + userReview.BeerId);
        }

    }
}
