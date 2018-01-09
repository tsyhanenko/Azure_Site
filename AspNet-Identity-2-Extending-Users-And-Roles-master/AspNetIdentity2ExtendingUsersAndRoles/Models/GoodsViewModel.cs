using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models
{
    public class GoodsViewModel
    {
        public IEnumerable<Good> Goods { get; set; }
        public PageLinksModel Pages { get; set; }
        public string Category { get; set; }
    }
}