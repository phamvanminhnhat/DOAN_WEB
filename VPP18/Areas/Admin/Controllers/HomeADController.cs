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
            var E_ND = data.SANPHAMs.First(m => m.IdSP == id);
            return View(E_ND);
        }
        [HttpPost]
        public ActionResult Edit(SANPHAM dmsp, HttpPostedFileBase fileUpload)
        {
            var dmspdb = data.SANPHAMs.FirstOrDefault(m => m.IdSP == dmsp.IdSP);
            if (fileUpload != null)
            {
                System.IO.File.Delete(Path.Combine(Server.MapPath(savePath), dmspdb.HinhAnh.Replace(savePath, "")));
                dmspdb.HinhAnh = savePath + fileUpload.FileName;
                fileUpload.SaveAs(Path.Combine(Server.MapPath(savePath), fileUpload.FileName));
            }
            dmspdb.TenSP = dmsp.TenSP;
            data.SubmitChanges();
            return RedirectToAction("ListSanPham");
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

       

    }
}