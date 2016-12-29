using DesafioEcommerce.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioEcommerce.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Produtos()
        {
            return View();
        }

        public ActionResult Buy()
        {
            return View();
        }
    }
}
