using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<tbl_skills> _skillsRepository = new GenericRepository<tbl_skills>();
        // GET: Skill
        public ActionResult Index()
        {
            var skills = _skillsRepository.TGetListAll();
            return View(skills);

        }
    }
}