using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Controllers;
using System;
using Xunit;

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
    }
}
