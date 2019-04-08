using System.Web.Mvc;
using DAL;
using System.Collections;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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
        public int GetVideoLikes(int vid)
        {
            return VideoManager.GetVideoLikes(vid);
        }

        [HttpPost]
        public int GetVideoDislikes(int vid)
        {
            return VideoManager.GetVideoDislikes(vid);
        }

        [HttpPost]
        public bool addComment(int vid,string comment,int uid)
        {
            return VideoManager.CommentVideo(vid,comment,uid);
        }

        [HttpPost]
        public ActionResult SignUp(string username, string password)
        {
            UserManager.CreateUser(username, password, 1);
            Session["Username"] = username;
            return Redirect("~/Home/index");
        }

        [HttpPost]
        public string GetVideoComments(int vid)
        {
            return VideoManager.GetComments(vid);
        }
    }
}