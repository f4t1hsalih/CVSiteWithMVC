using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class InterestController : Controller
    {
        GenericRepository<tbl_interest> repo = new GenericRepository<tbl_interest>();

        // GET: Interest
        [HttpGet]
        public ActionResult Index()
        {
            var interest = repo.TGetListAll();
            return View(interest);
        }
        [HttpPost]
        public ActionResult Index(tbl_interest p)
        {
            var value = repo.TFind(x => x.int_id == 1);
            value.int_interest = p.int_interest;
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}