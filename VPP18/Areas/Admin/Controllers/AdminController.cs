using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VPP18.Models;
using System.Web.Mvc;

namespace VPP18.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var tdn = collection["TenDangNhap"];
            var matkhau = collection["MatKhau"];
            ADMIN nd = data.ADMINs.FirstOrDefault(n => n.TenDangNhap.Equals(tdn) && n.MatKhau.Equals(matkhau));
            if (nd != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TenDangNhap"] = nd;
                return RedirectToAction("Index", "HomeAD");
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }
    }
}