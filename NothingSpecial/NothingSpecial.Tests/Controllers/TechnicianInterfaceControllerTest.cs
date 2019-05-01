using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NothingSpecial.Controllers;
using NothingSpecial;
using System.Web.Mvc;
using NothingSpecial.Models;
using Moq;

namespace NothingSpecial.Tests.Controllers
{
    [TestClass]
    public class TechnicianInterfaceControllerTest
    {

        OpenJobModel ojm = new OpenJobModel();

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



            // Act

            // Assert
           

        }

        [TestMethod]
        public void Create()
        {
            // Arrange 
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

            // Act

            // Assert

        }

        [TestMethod]
        public void Delete()
        {
            // Arrange 
         

            // Act
          

            // Assert


        }

    }
}
