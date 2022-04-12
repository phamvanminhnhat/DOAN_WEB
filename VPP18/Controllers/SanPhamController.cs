using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;
using PagedList.Mvc;
using PagedList;

namespace VPP18.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult ListSP(int ? page)
        {
            //var all_SP = from ss in data.SANPHAMs select ss;
            //return View(all_SP);
            if (page == null) page = 1;
            var all_sanpham = (from s in data.SANPHAMs select s).OrderBy(m => m.IdSP);
            int pageSize = 4;
            int pageNum = page ?? 1;
            return View(all_sanpham.ToPagedList(pageNum, pageSize));
        }


        public ActionResult Detail(string id)
        {
            var D_sanpham = data.SANPHAMs.Where(m => m.IdSP == id).First();
            return View(D_sanpham);
        }


    }
}