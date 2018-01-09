using AspNetIdentity2ExtendingUsersAndRoles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentity2ExtendingUsersAndRoles.Controllers.MyControllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        static int goodsOnPage = 10;
        static List<Good> goods = GoodstRepository.GetRepository();
        public ActionResult Index(int id = 1)
        {
            ViewBag.Goods = goods;

            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            Good s = null;
            if (id != 0)
                s = goods.FirstOrDefault(x => x.GoodId == id);
            else
            {
                s = new Good { GoodId = goods.Max(x => x.GoodId) + 1 };
            }

            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(Good a)
        {


            if (ModelState.IsValid)
            {

                int index = goods
                    .IndexOf(goods.FirstOrDefault(x => x.GoodId == a.GoodId));
                if (index != -1)
                    goods[index] = a;
                else
                {
                    goods.Add(a);
                    a.GoodId = goods.Max(x => x.GoodId) + 1;
                }
                return RedirectToAction("Index");
            }
            else
                return View(a);
        }

        public PartialViewResult GetTable(int id = 1)
        {
            if (Request["g"] != null)
                goodsOnPage = Convert.ToInt32(Request["g"]);

            ViewBag.Goods = goods.Skip((id - 1) * goodsOnPage).Take(goodsOnPage);
            ViewBag.PageCount = Math.Ceiling(goods.Count / (double)goodsOnPage);
            return PartialView();
        }

        public ActionResult Remove(int? id = null)
        {
            if (id != null)
            {
                Good temp = goods.FirstOrDefault(x => x.GoodId == id);
                goods.Remove(temp);
            }
            return RedirectToAction("GetTable");
        }


    }
}