using _17bangMVC.Models.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMVC.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            MessageModel Model = new MessageModel
            {
                Messages = new List<MessageItemModel>
                {
                    new MessageItemModel{Content="你因为登录获得系统随机分配给你的 帮帮豆 1 枚，可用于感谢赞赏等。",Id = 1,Created=DateTime.Now },
                    new MessageItemModel{Content="叶飞加入了你的目标：线上学习",Id = 2,Created=DateTime.Now },
                    new MessageItemModel{Content="叶飞为你拆开了箱子（单号：56），你已获得  帮帮币 178枚。如有任何问题，可联系我们",Id = 3,Created=DateTime.Now },
                    new MessageItemModel{Content="叶飞出售给你的帮帮币已打包（交易单号：56），内含  帮帮币 178枚，请按约定及时（24小时以内）支付人民币356元后要求卖方开箱。如有任何问题，可查看查看帮助或联系我们",Id = 4,Created=DateTime.Now },
                    new MessageItemModel{Content="你因为登录获得系统随机分配给你的 帮帮豆 4 枚，可用于感谢赞赏等。",Id = 5,Created=DateTime.Now }

                }
            };   
            return View(Model);
        }
        [HttpPost]
        public ActionResult Index(MessageModel Model)
        {
            foreach (var item in Model.Messages)
            {
                if (item.Selecteed)
                {

                }
            }
            return RedirectToAction("Index");  
        }
    }
}