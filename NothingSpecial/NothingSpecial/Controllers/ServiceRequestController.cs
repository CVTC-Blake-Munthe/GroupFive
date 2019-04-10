#define TRACE
using NothingSpecial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

                // The controller adds the filled up model object to the database.
                db.OpenJobs.Add(openJobModel);
                db.SaveChanges();

                // Return to the ServiceRequestDetails page, and send in a filled up openJobModel object to the Redirect.
                return RedirectToAction("ServiceRequestDetails", openJobModel);
            }

            return View(openJobModel);
        }

        // GET: Service Request Details view
        public ActionResult ServiceRequestDetails(OpenJobModel openJobModel)
        {
            // If the openJobModel is empty, throw an exception.
            if (openJobModel == null)
            {
                throw new ArgumentNullException(nameof(openJobModel));
            }

            // Return the view with the filled up openJobModel object.
            return View(openJobModel);
        }

    }
}