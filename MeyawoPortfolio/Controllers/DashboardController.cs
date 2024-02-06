using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
            public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.flutterProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.isNotReadMessageCount = db.TblContact.Where(x => x.IsRead == false).Count();
            ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();
            ViewBag.cSharpProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.lastReferanceComment = db.LastReferanceCommet().FirstOrDefault();
            ViewBag.testimonialCount = db.TblTestimonial.Count();
            ViewBag.socialMediaCount = db.TblSocialMedia.Count();
            return View();
        }
    }
}