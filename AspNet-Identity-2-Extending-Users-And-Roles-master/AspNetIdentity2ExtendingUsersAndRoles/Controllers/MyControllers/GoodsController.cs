using AspNetIdentity2ExtendingUsersAndRoles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentity2ExtendingUsersAndRoles.Controllers.MyControllers
{
    public class GoodsController : Controller
    {
        int pagesize = 3;
        static List<Good> goods = GoodstRepository.GetRepository();
        public ActionResult Index(int id = 1)
        {
            GoodsViewModel model = new GoodsViewModel
            {
                Goods = goods.Skip((id - 1) * pagesize).Take(pagesize),
                Pages = new PageLinksModel
                {
                    CurrentPage = id,
                    TotalItems = goods.Count(),
                    CountPerPage = pagesize
                }
            };


            return View(model);
        }

        public PartialViewResult GetGoodsList(int id = 1)
        {
            GoodsViewModel model = new GoodsViewModel
            {
                Goods = goods.Skip((id - 1) * pagesize).Take(pagesize),
                Pages = new PageLinksModel
                {
                    CurrentPage = id,
                    TotalItems = goods.Count(),
                    CountPerPage = pagesize
                }
            };

            return PartialView(model);
        }


        //TEST

        public PartialViewResult GetCategoryList(string category)
        {

            GoodsViewModel model = new GoodsViewModel
            {


                Goods = goods.FindAll(x => x.GoodCategory == category),
                Pages = new PageLinksModel
                {
                    CurrentPage = 1,
                    TotalItems = goods.Count(),
                    CountPerPage = pagesize
                }
            };

            return PartialView(model);
        }
    }


}