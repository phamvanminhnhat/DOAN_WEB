using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Areas.Admin.Controllers
{
    public class HomeADController : Controller
    {
        // GET: Admin/HomeAD
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListSanPham()
        {
            var all_sanpham = from ss in data.SANPHAMs select ss;
            return View(all_sanpham);
        }
        public ActionResult Detail(string id)
        {
            var D_sanpham = data.SANPHAMs.Where(m => m.IdSP == id).First();
            return View(D_sanpham);
            
        }
        public ActionResult Edit(string id)
        {
            var E_sanpham = data.SANPHAMs.First(m => m.IdSP == id);
            return View(E_sanpham);
        }
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            var E_idsanpham = data.SANPHAMs.First(m => m.IdSP == id);
            var E_iddm = data.SANPHAMs.First(m => m.IdDM == m.IdDM);
            var E_TenSP = collection["TenSP"];
            var E_HinhAnh = collection["HinhAnh"];
            var E_giaban = Convert.ToDecimal(collection["DonGia"]);
            var E_SoLuongTon = Convert.ToInt32(collection["SoLuongTon"]);
            var E_MoTa = collection["MoTa"];
            E_idsanpham.IdSP = id;
            if (string.IsNullOrEmpty(E_TenSP))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_idsanpham.TenSP = E_TenSP;
                E_idsanpham.HinhAnh = E_HinhAnh;
                E_idsanpham.DonGia = E_giaban;
                E_idsanpham.SoLuongTon = E_SoLuongTon;
                E_idsanpham.MoTa = E_MoTa;
                UpdateModel(E_idsanpham);
                data.SubmitChanges();
                return RedirectToAction("ListSanPham");
            }
            return this.Edit(id);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, SANPHAM sp)
        {
            var E_TenSP = collection["TenSP"];
            var E_hinhanh = collection["HinhAnh"];
            var E_dongia = Convert.ToDecimal(collection["DonGia"]);
            var E_soluongton = Convert.ToInt32(collection["SoLuongTon"]);
            var E_mota = collection["MoTa"];
            if (string.IsNullOrEmpty(E_TenSP))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                sp.TenSP = E_TenSP.ToString();
                sp.HinhAnh = E_hinhanh.ToString();
                sp.DonGia = E_dongia;
                sp.SoLuongTon = E_soluongton;
                sp.MoTa = E_mota;
                data.SANPHAMs.InsertOnSubmit(sp);
                data.SubmitChanges();
                return RedirectToAction("ListSanPham");
            }
            return this.Create();
        }
        public ActionResult Delete(string id)
        {
            var D_sanpham = data.SANPHAMs.First(m => m.IdSP == id);
            return View(D_sanpham);
        }
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            var D_sanpham = data.SANPHAMs.Where(m => m.IdSP == id).First();
            data.SANPHAMs.DeleteOnSubmit(D_sanpham);
            data.SubmitChanges();
            return RedirectToAction("ListSanPham");
        }
    
}
}