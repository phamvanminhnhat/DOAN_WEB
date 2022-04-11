using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult ListSP()
        {
            var all_SP = from ss in data.SANPHAMs select ss;
            return View(all_SP);
            
        }

        public ActionResult Detail(string id)
        {
            var D_sanpham = data.SANPHAMs.Where(m => m.IdSP == id).First();
            return View(D_sanpham);
        }


    }
}