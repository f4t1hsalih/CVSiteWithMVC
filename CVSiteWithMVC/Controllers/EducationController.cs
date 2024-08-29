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
            ModelState.Remove("edc_id");

            if (ModelState.IsValid)
            {
                educationRepo.TInsert(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        // GET: Education/EditEducation
        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            var education = educationRepo.TFind(x => x.edc_id == id);
            return View(education);
        }
        [HttpPost]
        public ActionResult EditEducation(tbl_education p)
        {
            if (ModelState.IsValid)
            {
                var education = educationRepo.TGetById(p.edc_id);
                education.edc_title = p.edc_title;
                education.edc_subtitle = p.edc_subtitle;
                education.edc_note = p.edc_note;
                education.edc_date = p.edc_date;
                education.edc_description = p.edc_description;
                educationRepo.TUpdate(education);
                return RedirectToAction("Index");
            }
            return View(p);
        }

        // GET: Education/DeleteEducation
        public ActionResult DeleteEducation(int id)
        {
            var education = educationRepo.TGetById(id);
            educationRepo.TDelete(education);
            return RedirectToAction("Index");
        }

    }
}