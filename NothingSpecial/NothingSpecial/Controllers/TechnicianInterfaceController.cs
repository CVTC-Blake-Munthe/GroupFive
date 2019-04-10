using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NothingSpecial.Models;

namespace NothingSpecial.Controllers
{
    public class TechnicianInterfaceController : Controller
    {
        private OpenJobsContext db = new OpenJobsContext();

        // GET: TechnicianInterface
        public ActionResult Index()
        {
            return View(db.OpenJobs.ToList());
        }

        // GET: TechnicianInterface/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJobModel openJobModel = db.OpenJobs.Find(id);
            if (openJobModel == null)
            {
                return HttpNotFound();
            }
            return View(openJobModel);
        }

        // GET: TechnicianInterface/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TechnicianInterface/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobID,FirstName,LastName,Email,PhoneNumber,Date,Message,TechNotes,Estimate,FinalCost,WorkComplete,AssetModel,AssetType")] OpenJobModel openJobModel)
        {
            if (ModelState.IsValid)
            {
                db.OpenJobs.Add(openJobModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(openJobModel);
        }

        // GET: TechnicianInterface/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJobModel openJobModel = db.OpenJobs.Find(id);
            if (openJobModel == null)
            {
                return HttpNotFound();
            }
            return View(openJobModel);
        }

        // POST: TechnicianInterface/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobID,FirstName,LastName,Email,PhoneNumber,Date,Message,TechNotes,Estimate,FinalCost,WorkComplete,AssetModel,AssetType")] OpenJobModel openJobModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(openJobModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(openJobModel);
        }

        // GET: TechnicianInterface/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJobModel openJobModel = db.OpenJobs.Find(id);
            if (openJobModel == null)
            {
                return HttpNotFound();
            }
            return View(openJobModel);
        }

        // POST: TechnicianInterface/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OpenJobModel openJobModel = db.OpenJobs.Find(id);
            db.OpenJobs.Remove(openJobModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
