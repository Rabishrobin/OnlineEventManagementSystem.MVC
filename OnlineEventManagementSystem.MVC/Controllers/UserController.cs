using System.Web.Mvc;
using OnlineEventManagementSystem.DAL;
using OnlineEventManagementSystem.Entity;

namespace OnlineEventManagementSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserRepository users = new UserRepository();
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserManager user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SignIn");
            }
            users.InsertUser(user);
            return View();
        }
        public ActionResult SignIn(UserManager user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}