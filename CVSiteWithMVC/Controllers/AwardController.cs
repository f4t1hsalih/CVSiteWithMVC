using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVSiteWithMVC.Repositories;
using CVSiteWithMVC.Models.Entity;

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
    }
}