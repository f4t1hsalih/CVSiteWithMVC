using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class CommunicationController : Controller
    {
        GenericRepository<tbl_communication> repo = new GenericRepository<tbl_communication>();
        public ActionResult Index()
        {
            var list = repo.TGetListAll();
            return View(list);
        }

    }
}
