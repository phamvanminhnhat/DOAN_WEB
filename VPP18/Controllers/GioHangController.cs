using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Controllers
{
    public class GioHangController : Controller
    {

        MyDataDataContext data = new MyDataDataContext();
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;

            }
            return lstGioHang;
        }

        public ActionResult ThemGioHang(string id, string strURL)

        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang SanPham = lstGioHang.Find(n => n.IdSP == id);
            if (SanPham == null)
            {
                SanPham = new GioHang(id);
                lstGioHang.Add(SanPham);
                return Redirect(strURL);
            }
            else
            {
                SanPham.SoLuong++;
                return Redirect(strURL);
            }
        }


        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tsl = lstGioHang.Sum(n => n.SoLuong);

            }
            return tsl;
        }
        private int TongSoLuongSanPham()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tsl = lstGioHang.Count;
            }
            return tsl;
        }

        private double TongTien()
        {
            double tt = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tt = lstGioHang.Sum(n => n.ThanhTien);
            }
            return tt;
        }


        public ActionResult GioHang()
        {
            List<GioHang> lstGioHang = LayGioHang();
            ViewBag.TongsoLuong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            ViewBag.Message = Session["Message"];
            ViewBag.AlertStatus = Session["AlertStatus"];
            Session.Remove("Message");
            Session.Remove("AlertStatus");
            return View(lstGioHang);
        }

        public ActionResult GioHangPartial()
        {
            ViewBag.TongsoLuong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return PartialView();
        }

        public ActionResult CapnhatGioHang(string id, FormCollection collection)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.IdSP == id);
            if (sanpham != null)
            {
                SANPHAM sp = data.SANPHAMs.FirstOrDefault(n => n.IdSP == id);

                int soluong = int.Parse(collection["txtSoLg"].ToString());
                if (soluong > sp.SoLuongTon)
                {
                    Session["Message"] = "Không đủ số lượng";
                    Session["AlertStatus"] = "danger";
                    return RedirectToAction("GioHang");
                }
                sanpham.SoLuong = soluong;

                //sanpham.iSoLuong = int.Parse(collection["txtSoLg"].ToString());
            }
            return RedirectToAction("GioHang");
        }

        public ActionResult XoaGioHang(string id)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.SingleOrDefault(n => n.IdSP == id);
            if (sanpham != null)
            {
                lstGioHang.RemoveAll(n => n.IdSP == id);
                return RedirectToAction("GioHang");
            }
            return RedirectToAction("GioHang");
        }

        public ActionResult XoaTatCagioHang()
        {
            List<GioHang> lstGioHang = LayGioHang();
            lstGioHang.Clear();
            return RedirectToAction("GioHang");
        }

        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "Home");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("GioHang", "GioHang");
            }
            List<GioHang> lstGiohang = LayGioHang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGiohang);
        }
        public ActionResult DatHang(FormCollection collection)
        {
            DONHANG dh = new DONHANG();
            NGUOIDUNG kh = (NGUOIDUNG)Session["TaiKhoan"];
            SANPHAM s = new SANPHAM();

            List<GioHang> gh = LayGioHang();
            var ngaygiao = String.Format("{0:MM/dd/yyyy}", collection["NgayGiao"]);

            dh.IdND = kh.IdND;
            dh.NgayDat = DateTime.Now;
            dh.NgayGiao = DateTime.Parse(ngaygiao);
            
            

            data.DONHANGs.InsertOnSubmit(dh);
            data.SubmitChanges();
            foreach (var item in gh)
            {
                THANHTOAN ctdh = new THANHTOAN();
                ctdh.MaDH = dh.MaDH;
                ctdh.IdSP = item.IdSP;
                ctdh.SoLuong = item.SoLuong;
                ctdh.TongTien = (decimal)item.GiaBan;
                s = data.SANPHAMs.Single(n => n.IdSP == item.IdSP);
                s.SoLuongTon -= ctdh.SoLuong;
                data.SubmitChanges();

                data.THANHTOANs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("Xacnhangiohang", "Giohang");
        }
        // GET: GioHang
        public ActionResult Xacnhangiohang()
        {
            return View();
        }

    }
}