using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NothingSpecial.Controllers;
using NothingSpecial;
using System.Web.Mvc;
using NothingSpecial.Models;
using Moq;
using System.Web.UI;

namespace NothingSpecial.Tests.Controllers
{
    [TestClass]
    public class TechnicianInterfaceControllerTest
    {
        
        OpenJobModel ojm = new OpenJobModel() {  JobID = 1, FirstName = "Bobbert" };

        [TestMethod]
        public void Index()
        {
            // Arrange 
            TechnicianInterfaceController controller = new TechnicianInterfaceController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Details() 
        {
            // Arrange 
            var context = new OpenJobsContext();
            context.OpenJobs.Add(ojm);
            TechnicianInterfaceController controller = new TechnicianInterfaceController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;
            

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Create()
        {
            // Arrange 
            var context = new OpenJobsContext();
            context.OpenJobs.Add(ojm);
            TechnicianInterfaceController controller = new TechnicianInterfaceController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Edit() 
        {
            // Arrange 
            var context = new OpenJobsContext();
            context.OpenJobs.Add(ojm);
            TechnicianInterfaceController controller = new TechnicianInterfaceController();

            // Act
            ViewResult result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void Delete() 
        {
            // Arrange 
            var context = new OpenJobsContext();
            context.OpenJobs.Add(ojm);
            TechnicianInterfaceController controller = new TechnicianInterfaceController();

            // Act
            ViewResult result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);


        }

    }
}
