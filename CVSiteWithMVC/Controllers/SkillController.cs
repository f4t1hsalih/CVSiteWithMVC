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
            if (ModelState.IsValid)
            {
                _skillsRepository.TInsert(skill);
                return RedirectToAction("Index");
            }
            return View(skill);
        }

        // DeleteSkill
        public ActionResult DeleteSkill(int id)
        {
            var skill = _skillsRepository.TFind(x => x.skl_id == id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            _skillsRepository.TDelete(skill);
            return RedirectToAction("Index");
        }

        // EditSkill
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skill = _skillsRepository.TFind(x => x.skl_id == id);
            if (skill == null)
            {
                return HttpNotFound();
            }
            return View(skill);
        }

        [HttpPost]
        public ActionResult EditSkill(tbl_skills skill)
        {
            if (ModelState.IsValid)
            {
                var existingSkill = _skillsRepository.TFind(x => x.skl_id == skill.skl_id);
                if (existingSkill == null)
                {
                    return HttpNotFound();
                }

                existingSkill.skl_skills = skill.skl_skills;
                existingSkill.skl_rate = skill.skl_rate;
                _skillsRepository.TUpdate(existingSkill);

                return RedirectToAction("Index");
            }
            return View(skill);
        }
    }
}
