using System.Web.Mvc;
using CVSiteWithMVC.Models.Entity;
using CVSiteWithMVC.Repositories;

namespace CVSiteWithMVC.Controllers
{
    //[Authorize]
    public class AboutController : Controller
    {
        GenericRepository<tbl_about> repo = new GenericRepository<tbl_about>();
        
        // GET: About
        [HttpGet]
        public ActionResult Index()
        {
            var about = repo.TGetListAll();
            return View(about);
        }
        [HttpPost]
        public ActionResult Index(tbl_about p)
        {
            var t = repo.TGetById(p.abt_id);
            t.abt_name = p.abt_name;
            t.abt_surname = p.abt_surname;
            t.abt_address = p.abt_address;
            t.abt_mail = p.abt_mail;
            t.abt_tel = p.abt_tel;
            t.abt_note = p.abt_note;
            t.abt_photo = p.abt_photo;
            t.abt_linkedin = p.abt_linkedin;
            t.abt_github = p.abt_github;
            t.abt_twitter = p.abt_twitter;
            t.abt_instagram = p.abt_instagram;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}