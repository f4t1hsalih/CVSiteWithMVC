using CVSiteWithMVC.Models.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            using (CVSiteWithMVCEntities db = new CVSiteWithMVCEntities())
            {
                var values = db.tbl_about.ToList();
                return View(values);
            }
        }
        public PartialViewResult Experience()
        {
            return PartialView();
        }
    }
}