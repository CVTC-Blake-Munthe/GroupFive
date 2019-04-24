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

            OpenJobModel ojm = new OpenJobModel();

            // Act
            ViewResult result = controller.ServiceRequestDetails(ojm) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
