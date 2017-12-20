using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicMenu.Models;
namespace DynamicMenu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MenuDBEntities db = new MenuDBEntities();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Categories()
        {
            ViewBag.menuLevel = db.Menu.Where(m => m.ParentId == null).ToList();
            return PartialView("Categories");
        }




        public ActionResult KategoriWithSubCategori()
        {



            return PartialView(new ViewModel
            {

                KategoriListesi = db.Kategori.ToList(),
                ProductListesi = db.Product.ToList()


        });
        }
}


public class ViewModel
{
    public List<Product> ProductListesi { get; set; }
    public List<Kategori> KategoriListesi { get; set; }

}
}