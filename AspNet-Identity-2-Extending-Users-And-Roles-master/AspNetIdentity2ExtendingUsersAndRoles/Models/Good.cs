using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models
{
    public class Good
    {
        public int GoodId { get; set; }
        [Required(ErrorMessage = "Введи название товара !")]
        public string GoodName { get; set; }
        [Required(ErrorMessage = "Введи цену!")]
        public int GoodPrice { get; set; }
        [Required(ErrorMessage = "Введи категорию!")]
        public string GoodCategory { get; set; }
        [Required(ErrorMessage = "Введи описание товара!")]
        public string GoodDescription { get; set; }
        public int GoodCount { get; set; }
        public string Image
        {
            get
            {
                return GoodId + ".jpg";
            }
        }

    }
}