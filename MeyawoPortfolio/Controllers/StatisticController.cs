using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
            public ActionResult Index()
        {
            //Aggregate ---> Sum Count Avg Min Max
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.flutterProjectCount = db.TblProject.Where(x=> x.ProjectCategory == 1).Count();
            ViewBag.pythonProjectCount = db.TblProject.Where(x=> x.ProjectCategory == 2).Count();
            ViewBag.mvcProjectCount = db.TblProject.Where(x=> x.ProjectCategory == 4).Count();
            ViewBag.coreProjectCount = db.TblProject.Where(x=> x.ProjectCategory == 5).Count();
            ViewBag.reactProjectCount = db.TblProject.Where(x=> x.ProjectCategory == 6).Count();
            ViewBag.cSharpProjectCount = db.TblProject.Where(x => x.ProjectCategory == 3).Count();
            ViewBag.isNotReadMessageCount = db.TblContact.Where(x=> x.IsRead == false).Count();
            ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();
            ViewBag.LastReferanceComment =db.LastReferanceCommet().FirstOrDefault();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
            ViewBag.socialMediaCount = db.TblSocialMedia.Count();
            return View();
        }
    }
}