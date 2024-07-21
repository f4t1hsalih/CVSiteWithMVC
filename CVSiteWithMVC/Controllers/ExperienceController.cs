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
            var values = exp.TGetListAll();
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
            exp.TInsert(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            var value = exp.TGetById(id);
            exp.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = exp.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(tbl_experience p)
        {
            tbl_experience value = exp.TFind(x => x.exp_id == p.exp_id);
            value.exp_title = p.exp_title;
            value.exp_subtitle = p.exp_subtitle;
            value.exp_description = p.exp_description;
            value.exp_date = p.exp_date;
            exp.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}