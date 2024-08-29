using CVSiteWithMVC.Models.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace CVSiteWithMVC.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        // GET: LogIn
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbl_admin adm)
        {
            CVSiteWithMVCEntities db = new CVSiteWithMVCEntities();
            var value = db.tbl_admin.FirstOrDefault(x => x.adm_username == adm.adm_username && x.adm_password == adm.adm_password);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.adm_username, false);
                Session["username"] = adm.adm_username.ToString();
                return RedirectToAction("Index","About");
            }
            else
            {
                return RedirectToAction("Index", "LogIn");
            }
        }

        public ActionResult Exit()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","LogIn");
        }

    }
}