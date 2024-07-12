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
    }
}