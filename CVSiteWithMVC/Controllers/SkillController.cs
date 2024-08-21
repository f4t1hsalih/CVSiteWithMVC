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

        // AddSkill
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(tbl_skills skill)
        {
            _skillsRepository.TInsert(skill);
            return RedirectToAction("Index");
        }

        //DeleteSkill
        public ActionResult DeleteSkill(int id)
        {
            var skill = _skillsRepository.TFind(x => x.skl_id == id);
            _skillsRepository.TDelete(skill);
            return RedirectToAction("Index");
        }
    }
}