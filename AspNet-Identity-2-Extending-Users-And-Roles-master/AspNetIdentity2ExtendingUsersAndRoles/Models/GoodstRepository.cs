using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models
{
    public class GoodstRepository
    {
        static List<Good> Goods = new List<Good>
        {
           new Good { GoodId = 1, GoodCount=1, GoodName = "Iphone 7", GoodPrice = 700, GoodCategory = "Phones", GoodDescription ="Экран (5.5 IPS, 1920x1080)/ Apple A10 Fusion/ основная камера: двойная 12 Мп, фронтальная камера: 7 Мп/ RAM 3 ГБ/ 32 ГБ встроенной памяти/ 3G/ LTE/ GPS/ Nano-SIM/ iOS10",},
           new Good { GoodId = 2,GoodCount=1, GoodName = "iPod classic ", GoodPrice = 500, GoodCategory = "Players", GoodDescription ="160 ГБ / AAC / MP3 / WAV / AIFF / JPEG / BMP / GIF / MP4 / MOV / TIFF / LCD дисплей / USB 2.0 / 140 г."},
           new Good { GoodId = 3,GoodCount=1, GoodName = "MacBook", GoodPrice = 2000, GoodCategory = "Laptops", GoodDescription ="Экран 15.4 IPS (2880x1800) Retina LED, глянцевый / Intel Core i7 (2.2 ГГц) / RAM 16 ГБ / SSD 256 ГБ / Intel Iris Pro Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / OS X Yosemite / 2.04 кг",},
           new Good { GoodId = 4,GoodCount=1, GoodName = "PocketBook ", GoodPrice = 500, GoodCategory = "Ebook", GoodDescription ="Количество градаций серого: 16 Диагональ дисплея: 6 Разрешение: 800х600 Тип матрицы: E Ink Carta Встроенная память: 8 ГБ Вес: 180 г ",},
           new Good { GoodId = 5,GoodCount=1, GoodName = "Lenovo Legion Y520-15IKBN", GoodPrice = 1700, GoodCategory = "Laptops", GoodDescription ="Экран 15.6 IPS (1920x1080) Full HD, матовый / Intel Core i7-7700HQ (2.8 - 3.8 ГГц) / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1050 Ti, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / веб-камера / DOS / 2.4 кг / черный ",},
           new Good { GoodId = 6,GoodCount=1, GoodName = "Asus N752VX ", GoodPrice = 1600, GoodCategory = "Laptops", GoodDescription ="Экран 17.3 IPS (3840x2160) 4K UHD, матовый / Intel Core i5-6300HQ (2.3 - 3.2 ГГц) / RAM 16 ГБ / SSD 128 ГБ + HDD 1 ТБ / nVidia GeForce GTX 950M, 4 ГБ / DVD Super Multi / LAN / Wi-Fi / Bluetooth / веб-камера / Windows 10 / 2.7 кг",},
           new Good { GoodId = 7,GoodCount=1, GoodName = "Samsung Galaxy S8", GoodPrice = 1300, GoodCategory = "Phones", GoodDescription ="Экран (5.8, Super AMOLED, 2960х1440)/ Samsung Exynos 8895 (4 x 2.3 ГГц + 4 x 1.7 ГГц)/ основная камера 12 Мп + фронтальная 8 Мп/ RAM 4 ГБ/ 64 ГБ встроенной памяти + microSD (до 256 ГБ)/ 3G/ LTE/ GPS/ поддержка 2х SIM-карт (Nano-SIM)/ Android 7.0 (Nougat) / 3000 мА*ч ",},
           new Good { GoodId = 8,GoodCount=1, GoodName = "iPad A1822", GoodPrice = 700, GoodCategory = "Tablet", GoodDescription ="Экран 9.7 IPS (2048x1536) емкостный MultiTouch / Apple A9 / RAM 2 ГБ / 32 ГБ встроенной памяти / Wi-Fi / Bluetooth 4.2 / основная камера 8 Мп, фронтальная - 1.2 Мп / iOS 10 / 469 г / серый космос ",},
           new Good { GoodId = 9,GoodCount=1, GoodName = "Lenovo Tab 3-850", GoodPrice = 200, GoodCategory = "Tablet", GoodDescription ="Экран 8 (1280х800) IPS, емкостный MultiTouch / MediaTek MT8735P (1.0 ГГц) / RAM 2 ГБ / 16 ГБ встроенной памяти + microSD / Wi-Fi / Bluetooth 4.0 / основная камера 5 Мп + фронтальная 2 Мп / GPS / Android 6.0 (Marshmallow)/ 330 г / черный ",},
              new Good { GoodId = 10,GoodCount=1, GoodName = "SteelSeries Arctis 3", GoodPrice = 1000, GoodCategory = "Players", GoodDescription ="Тип наушников Закрытые  Диапазон частот наушников 20 - 22000 Гц Сопротивление наушников 32 Ом Чувствительность наушников 98 дБ  ",},


        };
        public static List<Good> GetRepository()
        {
            return Goods;
        }
    }
}