using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Controllers;
using ReviewsSites.ReviewsRepositories;
using System;
using Xunit;
using ReviewsSites.Models;
using System.Collections.Generic;

namespace ReviewsSites.Tests
{
    public class ReviewsControllerTests
    {
        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var underTest = new ReviewsController();
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Reviews_Repository_Has_Three_Beers()
        {
            var underTest = new ReviewsRepository();
            


            
        }
    }
}
