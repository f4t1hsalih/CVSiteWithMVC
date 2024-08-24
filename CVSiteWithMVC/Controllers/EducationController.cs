using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class EducationController : Controller
    {

        GenericRepository<tbl_education> educationRepo = new GenericRepository<tbl_education>();

        // GET: Education
        public ActionResult Index()
        {
            var values = educationRepo.TGetListAll();
            return View(values);
        }

        // GET: Education/AddEducation
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(tbl_education p)
        {
            educationRepo.TInsert(p);
            return RedirectToAction("Index");
        }

    }
}