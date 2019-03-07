using Microsoft.AspNetCore.Mvc;
using ReviewsSites.Controllers;
using ReviewsSites.Models;
using ReviewsSites.ReviewsRepositories;
using Xunit;
using NSubstitute;
using ReviewsSites.Repositories;
using System.Collections.Generic;

namespace ReviewsSites.Tests
{
    public class UserReviewControllerTests
    {
        UserReviewController underTest;
        private IUserReviewRepository repo;

        public UserReviewControllerTests()
        {
            repo = Substitute.For<IUserReviewRepository>();

            underTest = new UserReviewController(repo);
        }

        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
