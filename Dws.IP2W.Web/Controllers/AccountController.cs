using System.Web.Mvc;

namespace Dws.IP2W.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult LogOn()
        {
            return View();
        }

        //
        // GET: /Register/
        public ActionResult NewUser()
        {
            return View();
        }
    }
}
