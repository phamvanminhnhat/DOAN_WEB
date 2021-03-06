using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;


namespace VPP18.Controllers
{
    
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            return View(data.DANHMUCSANPHAMs.Take(10).ToList());
        }
       
        public ActionResult About()
        {
            //var item = data.DANHMUCSANPHAMs.FirstOrDefault(m => m.IdDM == id);
            //item.SANPHAMs.Take(10).ToList();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // ĐĂNG KÍ TÀI KHOẢN NGƯỜI DÙNG
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(FormCollection collection)
        {          
            var tennguoidung = collection["TenND"];
     
            var dienthoai = collection["SDT"];
            var diachi = collection["DiaChi"];
            var email = collection["Email"];
            var matkhau2 = collection["MatKhau"];
            var matkhau = GetMD5(collection["MatKhau"]);
            var MatKhauXacNhan = GetMD5(collection["MatKhauXacNhan"]);

            NGUOIDUNG nd = new NGUOIDUNG();
            nd.TenND = tennguoidung;
            nd.SDT = dienthoai;
            nd.DiaChi = diachi;
            nd.Email = email;

            if (string.IsNullOrEmpty(MatKhauXacNhan))
            {
                ViewData["NhapMKXN"] = "Phải nhập mật khẩu xác nhận!";
            }
            else
            {
                if (!matkhau.Equals(MatKhauXacNhan))
                {
                    ViewData["MatKhauGiongNhau"] = "Mật khẩu và mật khẩu xác nhận phải giống nhau";
                }
                else
                {
                   
                    nd.MatKhau = matkhau2;

                    
                    data.NGUOIDUNGs.InsertOnSubmit(nd);
                    data.SubmitChanges();

                    return RedirectToAction("DangNhap");
                }
            }
            return View(nd);
        }
        //create a string MD5 mã hoá mật khẩu
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var email = collection["Email"];
            var matkhau = collection["MatKhau"];
            NGUOIDUNG nd = data.NGUOIDUNGs.FirstOrDefault(n => n.Email.Equals(email) && n.MatKhau.Equals(matkhau));
            if (nd != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TenND"] = nd;
                return RedirectToAction("GioHang", "GioHang");
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }

        public ActionResult DangXuat()
        {
            Session.Remove("TenND");
            return RedirectToAction("Index");
        }

    }

}