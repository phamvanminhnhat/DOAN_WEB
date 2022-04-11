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
            var tendangnhap = collection["TenDangNhap"];
            var matkhau = collection["MatKhau"];
            ADMIN nd = data.ADMINs.FirstOrDefault(n => n.TenDangNhap == tendangnhap && n.MatKhau == matkhau);
            if (nd != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TenDangNhap"] = nd;
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return RedirectToAction("ListSanPham", "HomeAD");
        }
    }
}