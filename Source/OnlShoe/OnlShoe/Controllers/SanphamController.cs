using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlShoe.Models;

namespace OnlShoe.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult nikePartial()
        {
            var nike = db.Sanphams.Where(n => n.Mahang == 1 && n.Loai != "Sale").Take(4).ToList();
            return PartialView(nike);
        }
        public ActionResult addidaspartial()
        {
            var addidas = db.Sanphams.Where(n => n.Mahang == 2 && n.Loai != "Sale").Take(4).ToList();
            return PartialView(addidas);
        }
        public ActionResult conversepartial()
        {
            var converse = db.Sanphams.Where(n => n.Mahang == 3 && n.Loai != "Sale").Take(4).ToList();
            return PartialView(converse);
        }
        public ActionResult addidaspartial_sale()
        {
            var addidas_sale = db.Sanphams.Where(n => n.Mahang == 2 && n.Loai == "Sale").Take(4).ToList();
            return PartialView(addidas_sale);
        }
        public ActionResult conversepartial_sale()
        {
            var converse_sale = db.Sanphams.Where(n => n.Mahang == 3 && n.Loai == "Sale").Take(4).ToList();
            return PartialView(converse_sale);
        }
        public ActionResult nikePartial_sale()
        {
            var nike_sale = db.Sanphams.Where(n => n.Mahang == 1 && n.Loai == "Sale").Take(4).ToList();
            return PartialView(nike_sale);
        }
        public ActionResult xemchitiet(int Masp = 0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n => n.Masp == Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }

}