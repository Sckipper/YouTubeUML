using System.Web.Mvc;
using DAL;

namespace YouTubeUML.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(UserManager.LoginUser(username, password))
                Session["Username"] = username;
            return Redirect("~/Home/index");
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Clear();
            return Redirect("~/Home/index");
        }

        public ActionResult VideoPage()
        {
            return View();
        }

        [HttpPost]
        public void LikeVideo(int vid)
        {
            VideoManager.LikeVideo(vid);
        }

        [HttpPost]
        public void DislikeVideo(int vid)
        {
            VideoManager.DislikeVideo(vid);
        }

        [HttpPost]
        public ActionResult SignUp(string username, string password)
        {
            UserManager.CreateUser(username, password, 1);
            Session["Username"] = username;
            return Redirect("~/Home/index");
        }
    }
}