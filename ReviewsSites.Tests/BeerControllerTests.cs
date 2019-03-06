using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewsSites.Controllers;
using ReviewsSites.Models;
using ReviewsSites.Repositories;
using Xunit;

namespace ReviewsSites.Tests
{
    public class BeerControllerTests
    {
        BeerController underTest;
        private IBeerRepository repo;

        public BeerControllerTests()
        {
            repo = Substitute.For<IBeerRepository>();

            underTest = new BeerController(repo);
        }

        [Fact]
        public void Index_Returns_ViewResult()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Beer>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Beer>)result.Model;

            Assert.Equal(expectedModel, model);
        }
        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Beer();
            repo.GetById(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Beer)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
