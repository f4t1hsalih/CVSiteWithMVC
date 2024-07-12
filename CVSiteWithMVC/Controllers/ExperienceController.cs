using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository exp = new ExperienceRepository();

        // GET: Experience
        public ActionResult Index()
        {
            var values = exp.GetListAll();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(tbl_experience p)
        {
            exp.Insert(p);
            return RedirectToAction("Index");
        }
    }
}