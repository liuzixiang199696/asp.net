using _17bangMVC.Models;
using _17bangMVC.Models.Register;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace _17bangMVC.Controllers
{
    public class RegisterController : Controller
    {
        public const string CAPTCHA = "captcha";
        public DbSet<RegisterModel> Entities { get; set; }
        public SQLDbContext db { get; set; } = new SQLDbContext();

        [HttpGet]
        //[OutputCache(Duration =100,VaryByParam ="id")]
        public ActionResult Index(int? id)
        {
            Thread.Sleep(1000);
            RegisterModel indexModel = new RegisterModel
            {
                IsMan = true
            };
            ViewBag.id = id;
            return View(indexModel);
        }
        public ActionResult Getcaptcha()
        {
            byte[] captcha = Makecaptcha(out string value);
            Session[CAPTCHA] = value;
            return File(captcha, "jpg");
        }
        public byte[] Makecaptcha(out string value)
        {
            Bitmap bitmap = new Bitmap(60, 30);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 12, (FontStyle.Bold | FontStyle.Italic));
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                Color.DarkCyan, Color.AliceBlue, 1.2f, true);
            value = new Random().Next(1000, 9999).ToString();
            graphics.DrawString(value, font, brush, 3, 2);
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();

        }

        [HttpPost]
        public ActionResult Index(string name, RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.captcha!=Session[CAPTCHA].ToString())
            {
                ModelState.AddModelError(CAPTCHA, "验证码输入错误！");
                return View(model);
            }
            name = model.UserName;
            ViewBag.UserName = name;
            model.Money = 10;
            Save(model);
            return View(model);
        }
        [ChildActionOnly]
        [OutputCache(Duration = 30)]
        public PartialViewResult Reminder()
        {
            return PartialView();
        }
        public void Save(RegisterModel model)
        {
            SQLDbContext dbContext = new SQLDbContext();
            dbContext.Registers.Add(model);
            dbContext.SaveChanges();
        }
        public JsonResult DuplicateUsername(string UserName)
        {
            return Json(db.Registers.Where(u => u.UserName == UserName).SingleOrDefault()==null,  
                JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ViewResult Icon(HttpPostedFileWrapper icon)
        {
             string path= Path.GetFileName(icon.FileName);
            icon.SaveAs(Path.Combine(Server.MapPath("~/Image/"), path));
            return View();

        }
    }
}