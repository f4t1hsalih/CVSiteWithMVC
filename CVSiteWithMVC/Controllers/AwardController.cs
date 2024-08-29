using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class AwardController : Controller
    {
        GenericRepository<tbl_award> awardRepo = new GenericRepository<tbl_award>();

        // GET: Award
        public ActionResult Index()
        {
            var awards = awardRepo.TGetListAll();
            return View(awards);
        }

        // GET: EditAward
        [HttpGet]
        public ActionResult EditAward(int id)
        {
            var award = awardRepo.TFind(x => x.awd_id == id);
            return View(award);
        }
        [HttpPost]
        public ActionResult EditAward(tbl_award award)
        {
            var value = awardRepo.TGetById(award.awd_id);
            value.awd_award = award.awd_award;
            value.awd_date = award.awd_date;
            awardRepo.TUpdate(value);
            return RedirectToAction("Index");
        }

        // GET: AddAward
        [HttpGet]
        public ActionResult AddAward()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAward(tbl_award award)
        {
            awardRepo.TInsert(award);
            return RedirectToAction("Index");
        }

        // GET: DeleteAward
        public ActionResult DeleteAward(int id)
        {
            awardRepo.TDelete(awardRepo.TFind(x => x.awd_id == id));
            return RedirectToAction("Index");
        }

    }
}