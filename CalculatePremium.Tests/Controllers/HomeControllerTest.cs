using CalculatePremium;
using CalculatePremium.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace CalculatePremium.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private decimal ExpectedResult_getOccupationFactor = 1.75M;
        private decimal ExpectedResult_getOccupationFactor_empty = 0M;
        private List<string> ExpectedResult_getOccupations = new List<string> {"Cleaner", "Doctor", "Author", "Farmer", "Mechanic", "Florist"};
        [TestMethod]
        public void getOccupationFactor()
        {
            // Arrange
            HomeController controller = new HomeController();
            CalculatePremiumController premiumController = new CalculatePremiumController();
            // Act
            decimal result = premiumController.GetOccupationFactor("Farmer") ;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(ExpectedResult_getOccupationFactor, result);
        }
        //[TestMethod]
        //public void getOccupationFactor_empty()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();
        //    CalculatePremiumController premiumController = new CalculatePremiumController();
        //    // Act
        //    decimal result = premiumController.GetOccupationFactor("");
        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(ExpectedResult_getOccupationFactor_empty, result);
        //}
        
        [TestMethod]
        public void getOccupations()
        {
            // Arrange
            HomeController controller = new HomeController();
            CalculatePremiumController premiumController = new CalculatePremiumController();
            // Act
            List<string> result = premiumController.getOccupations();
            // Assert
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(ExpectedResult_getOccupations, result, StructuralComparisons.StructuralComparer);
        }

       


    }
}
