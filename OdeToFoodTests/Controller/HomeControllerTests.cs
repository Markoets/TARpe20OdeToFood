using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFoodTests.Controller
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void About()
        {
            //Arrange
            HomeController controller = new HomeController();

            //act
            ViewResult result = controller.About() as ViewResult;
            //assert
            Assert.IsNotNull(result.Model);


        }
    }
}
