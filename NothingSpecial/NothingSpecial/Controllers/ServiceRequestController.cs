#define TRACE
using NothingSpecial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace NothingSpecial.Controllers
{
    public class ServiceRequestController : Controller
    {
        // Create a OpenJobsContext object to communicate with the OpenJob model.
        private OpenJobsContext db = new OpenJobsContext();

        // GET: Service Request Form view
        public ActionResult ServiceRequestForm()
        {
            // Return the view named ServiceRequestForm. For more info about how routing works, look at the RouteConfig.cs
            // file
            return View();
        }

        // POST: Service Request Form view
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Bind is used to only pass an object with only the parameters included below.  
        public ActionResult ServiceRequestForm([Bind(Include = "JobID,FirstName,LastName,Email,PhoneNumber,Date,Message")] OpenJobModel openJobModel)
        {
            // If the instance variables are OK'd with the model, then continue.  
            if (ModelState.IsValid)
            {

                // The controller adds the filled up model object to the database. TODO: REMOVE THIS
                // db.OpenJobs.Add(openJobModel);
                // db.SaveChanges();

                // Return to the ServiceRequestDetails page, and send in a filled up openJobModel object to the Redirect.
                return RedirectToAction("ServiceRequestDetails", openJobModel);
            }

            return View(openJobModel);
        }

        // GET: Service Request Details view
        public ActionResult ServiceRequestDetails(OpenJobModel openJobModel)
        {
            /* ********** Uncomment when the dummy email account is made **********
             
            // If the openJobModel is empty, throw an exception.
            if (openJobModel == null)
            {
                throw new ArgumentNullException(nameof(openJobModel));
            }
            else {
                
                 
                // Notes: https://stackoverflow.com/questions/26784366/how-to-send-email-from-mvc-5-application
                // Setting the object member variables to local variables
                var fullName = openJobModel.FirstName.ToString() + openJobModel.LastName.ToString();
                var email = openJobModel.Email.ToString();
                var phoneNumber = openJobModel.PhoneNumber.ToString();
                var date = openJobModel.Date.ToString();
                var message = openJobModel.Message.ToString();

                // String format for message body
                var body = "<h1>Lead details</h1><br><br> <p>{0}</p><br> <p>{1}</p><br> <p>{2}</p><br> <p>{3}</p><br> <p>{4}</p><br>";

                // Creating a Smtp client object to send the email in
                SmtpClient client = new SmtpClient();

                // Create a new email to send through the client
                MailMessage mailMessage = new MailMessage();

                // Email to send the message to
                mailMessage.To.Add("technicianleads@nothingspecial.com");

                // Subject for the email message
                mailMessage.Subject = "Service Request lead sent " + DateTime.Now.ToString();

                // Body for the email message, containing the lead information
                mailMessage.Body = string.Format(body, fullName, email, phoneNumber, date, message);

                // Send the email
                client.Send(mailMessage);
            }
             
            */


            // Return the view with the filled up openJobModel object.
            return View(openJobModel);
        }

    }
}