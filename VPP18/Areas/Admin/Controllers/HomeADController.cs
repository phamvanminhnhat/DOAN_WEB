using System;
using System.Collections.Generic;
using System.IO;
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
        string savePath = "/Content/images/";
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
            ViewBag.categories = data.DANHMUCSANPHAMs.ToList();
            ViewBag.suppliers = data.NCCs.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(SANPHAM sp, HttpPostedFileBase fileUpload)
        {
           if(fileUpload != null)
            {
                string fileName = fileUpload.FileName;
                sp.HinhAnh = fileName;
                fileUpload.SaveAs(Path.Combine(Server.MapPath(savePath), fileName));
            }
            data.SANPHAMs.InsertOnSubmit(sp);
            data.SubmitChanges();
           return RedirectToAction("ListSanPham");
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

        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }

    }
}