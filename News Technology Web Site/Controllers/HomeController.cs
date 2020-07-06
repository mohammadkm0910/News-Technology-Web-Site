using News_Technology_Web_Site.Array;
using News_Technology_Web_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace News_Technology_Web_Site.Controllers
{
    public class HomeController : Controller
    {
        AccountsEntities myDb = new AccountsEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            ViewBag.msg = "خوش آمدید.";
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                myDb.Users.Add(user);
                myDb.SaveChanges();
                ViewBag.notError = true;
                ViewBag.msg = "ثبت نام شما با موفقیت انجام شد.";
                
            }
            catch (Exception)
            {
                ViewBag.notError = false;
                ViewBag.msg = "مشکلی در ثبت نام پیش آمد.";
            }
           
            return View();
        }
        public ActionResult Bril()
        {
            return View();
        }
        public ActionResult Robot() { 
            return View();
        }
        public ActionResult Self() {
            return View();
        }
        public ActionResult SpaceX()
        {
            return View();
        }
        public ActionResult Submarine()
        {
            return View();
        }
        public ActionResult CameraFraming()
        {
            return View();
        }
        public ActionResult DownloadVideoTwitter()
        {
            return View();
        }
        public ActionResult DownloadWeb()
        {
            return View();
        }    
        public ActionResult GmailShortcuts()
        {
            TableGS tableGS = new TableGS();
            ViewBag.gs = tableGS.GmailShortcut();
            return View();
        }
        public ActionResult VirtualDesktopWindows10()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Comments()
        {
            return PartialView("_Comments");
        }
        [ChildActionOnly]
        public ActionResult SearchBar()
        {
            return PartialView("_SearchBar");
        }
        [ChildActionOnly]
        public ActionResult NavTop()
        {
            List<string> items = new List<string>();
            items.Add("اخبار و تکنولوژی");
            //زیر منو
            items.Add("ایران و جهان");
            //پایان زیر منو
            items.Add("موبایل و تبلت");
            //زیر منو
            items.Add("اپلیکیشن");
            items.Add("سامسونگ");
            items.Add("هواوی");
            items.Add("اپل");
            items.Add("کسب و کار");
            //پایان زیر منو
            items.Add("دانش");
            ViewBag.menu = items;
            return PartialView("_NavTop");
        }
        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView("_Footer");
        }
    }
}