using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;
using System.Web.Mvc;

namespace CVSiteWithMVC.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<tbl_admin> repo = new GenericRepository<tbl_admin>();
        // GET: Admin
        public ActionResult Index()
        {
            var value = repo.TGetListAll();
            return View(value);
        }

        //GET: AddAdmin
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(tbl_admin adm)
        {
            repo.TInsert(adm);
            return RedirectToAction("Index");
        }
        //GET: EditAdmin
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var value = repo.TFind(x => x.adm_id == id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditAdmin(tbl_admin adm)
        {
            var value = repo.TFind(x => x.adm_id == adm.adm_id);

            value.adm_username = adm.adm_username;
            value.adm_password = adm.adm_password;
            repo.TUpdate(value);

            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            var value = repo.TFind(x => x.adm_id == id);
            if (value != null)
            {
                repo.TDelete(value);
            }
            return RedirectToAction("Index");
        }
    }
}