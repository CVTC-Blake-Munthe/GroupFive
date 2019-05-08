using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NothingSpecial.Controllers;
using NothingSpecial;
using System.Web.Mvc;
using NothingSpecial.Models;

namespace NothingSpecial.Tests.Controllers
{
    [TestClass]
    public class ServiceRequestControllerTest
    {
        [TestMethod]
        public void ServiceRequestForm()
        {
            // Arrange 
            ServiceRequestController controller = new ServiceRequestController();

            // Act
            ViewResult result = controller.ServiceRequestForm() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void ServiceRequestDetails()
        {
            // Arrange 
            ServiceRequestController controller = new ServiceRequestController();

            OpenJobModel ojm = new OpenJobModel
            {
                FirstName = "Albumius",
                LastName = "Artistus",
                Email = "1234@gmail.com",
                PhoneNumber = "715-555-5555",
                Date = DateTime.Now,
                Message = "hackle frackle",
                TechNotes = "I am a technote",
                Estimate = 10.00,
                FinalCost = 10.00,
                WorkComplete = true,
                AssetModel = "1337",
                AssetType = "Laptop"
            }; ;

            // Act
            ViewResult result = controller.ServiceRequestDetails(ojm) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
