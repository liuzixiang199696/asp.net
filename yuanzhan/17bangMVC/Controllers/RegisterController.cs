﻿using _17bangMVC.Models.Register;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class RegisterController : Controller
    {
        public const string CAPTCHA = "captcha";

        [HttpGet]
        public ActionResult Index(int? id)
        {
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
                ModelState.AddModelError("captcha", "验证码输入错误！");
                return View(model);
            }
            name = model.UserName;
            ViewBag.UserName = name;
            return View(model);
        }
        [ChildActionOnly]
        public PartialViewResult Reminder()
        {
            return PartialView();
        }

    }
}