using AspNetIdentity2ExtendingUsersAndRoles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentity2ExtendingUsersAndRoles.Controllers.MyControllers
{
    public class NavController : Controller
    {
        static List<Good> goods = GoodstRepository.GetRepository();
        public PartialViewResult Menu()
        {
            IEnumerable<string> category = goods
                .Select(x => x.GoodCategory)
                .Distinct()
                .ToList();
            return PartialView(category);
        }
    }
}