using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Controllers;
using ReviewsSites.Models;
using ReviewsSites.ReviewsRepositories;
using Xunit;

namespace ReviewsSites.Tests
{
    public class ReviewsControllerTests
    {
        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var underTest = new BeerController(null);
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Reviews_Repository_Has_Three_Beers()
        //{
        //    var underTest = new ReviewsRepository(null);
        //    var result = underTest.reviewList.Count;
        //    Assert.Equal(3, result);
        //}

        [Fact]
        public void Details_returns_correct_Id()
        {
            var underTest = new BeerController(null);
            var expectedId = 2;
            var results = underTest.Details(expectedId);
            var model = (Beer)results.Model;
            Assert.Equal(2, model.BeerId);
        }

    }
}
