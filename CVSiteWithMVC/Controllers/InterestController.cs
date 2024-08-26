using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class InterestController : Controller
    {
        GenericRepository<tbl_interest> repo = new GenericRepository<tbl_interest>();

        // GET: Interest
        public ActionResult Index()
        {
            var interest = repo.TGetListAll();
            return View(interest);
        }
    }
}