using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NothingSpecial.Controllers;
using NothingSpecial;
using System.Web.Mvc;
using System.Net.Mail;
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

            OpenJobModel openJobModel = new OpenJobModel
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
            };

            var fullName = openJobModel.FirstName.ToString() + openJobModel.LastName.ToString();
            var email = openJobModel.Email.ToString();
            var phoneNumber = openJobModel.PhoneNumber.ToString();
            var date = openJobModel.Date.ToString();
            var message = openJobModel.Message.ToString();

            
            var body = "Lead details: {0} // {1} // {2} // {3} // {4}";

            
            SmtpClient client = new SmtpClient();

            
            MailMessage mailMessage = new MailMessage();

            
            mailMessage.To.Add("nothingspecialtest@gmail.com");

            
            mailMessage.Subject = "Service Request lead sent " + DateTime.Now.ToString();

            
            mailMessage.Body = string.Format(body, fullName, email, phoneNumber, date, message);

            
            client.Send(mailMessage);

            // Act
            ViewResult result = controller.ServiceRequestDetails(openJobModel) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
