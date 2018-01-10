using AspNetIdentity2ExtendingUsersAndRoles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentity2ExtendingUsersAndRoles.Controllers.MyControllers
{
    public class CartController : Controller
    {

        static List<Good> goods = GoodstRepository.GetRepository();
        static List<Good> CartList = new List<Good>();
        int TotalPrice = 0;

        public ActionResult Index()
        {
            var model = CartList;
            return View(model);
        }


        public ActionResult Remove(int id)
        {
            Good temp = CartList.FirstOrDefault(x => x.GoodId == id);
            CartList.Remove(temp);
            return RedirectToAction("Index");

        }

        public ActionResult GetTotal()
        {
            foreach (Good item in CartList)
            {
                TotalPrice += (item.GoodCount * item.GoodPrice);
            }
            ViewBag.Total = TotalPrice;
            return View(ViewBag.Total);
        }

        public ActionResult Add(int id)
        {
            if (id != 0)
            {
                if (ModelState.IsValid)
                {
                    Good tmp = goods.FirstOrDefault(x => x.GoodId == id);

                    if (CartList.Contains(tmp))
                    {
                        tmp.GoodCount++;
                    }
                    else
                    {
                        CartList.Add(tmp);
                    }
                }


            }

            return RedirectToAction("Index", "Goods");
        }
    }
}