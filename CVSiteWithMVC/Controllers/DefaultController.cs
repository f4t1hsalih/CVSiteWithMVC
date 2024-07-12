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
    }
}
