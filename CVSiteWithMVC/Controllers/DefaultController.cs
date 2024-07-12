using CVSiteWithMVC.Models.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult About()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var about = db.tbl_about.ToList();
                return PartialView("About", about);
            }
        }

        public PartialViewResult Experience()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var experience = db.tbl_experience.ToList();
                return PartialView("Experience", experience);
            }
        }
        public PartialViewResult Education()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var education = db.tbl_education.ToList();
                return PartialView("Education", education);
            }
        }
        public PartialViewResult Skill()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var skill = db.tbl_skills.ToList();
                return PartialView("Skill", skill);
            }
        }
        public PartialViewResult Interest()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var interest = db.tbl_interest.ToList();
                return PartialView("Interest", interest);
            }
        }
        public PartialViewResult Award()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var award = db.tbl_award.ToList();
                return PartialView("Award", award);
            }
        }
        [HttpGet]
        public PartialViewResult Communication()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var communication = db.tbl_communication.ToList();
                return PartialView("Communication", communication);
            }
        }
        [HttpPost]
        public PartialViewResult Communication(tbl_communication com)
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                com.cmt_date = System.DateTime.Today;
                db.tbl_communication.Add(com);
                db.SaveChanges();
                return PartialView();
            }
        }
    }
}
