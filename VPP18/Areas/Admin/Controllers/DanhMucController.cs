using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Areas.Admin.Controllers
{
    public class DanhMucController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        private const string savePath = "/Content/images/";
        // GET: DanhMucSanPham
        public ActionResult Danhmuc()
        {
            var lstDanhmuc = data.DANHMUCSANPHAMs.ToList();
            return View(lstDanhmuc);
        }

        public ActionResult Detail(int id)
        {
            var D_ND = data.DANHMUCSANPHAMs.Where(m => m.IdDM == id).First();
            return View(D_ND);

        }
        public ActionResult Edit(int id)
        {
            var E_ND = data.DANHMUCSANPHAMs.First(m => m.IdDM == id);
            return View(E_ND);
        }
        [HttpPost]
        public ActionResult Edit(DANHMUCSANPHAM dmsp, HttpPostedFileBase fileUpload)
        {
            var dmspdb = data.DANHMUCSANPHAMs.FirstOrDefault(m => m.IdDM == dmsp.IdDM);
            if(fileUpload != null)
            {
                System.IO.File.Delete(Server.MapPath(dmsp.HinhAnh));
                dmspdb.HinhAnh = savePath + fileUpload.FileName;
                fileUpload.SaveAs(Path.Combine(Server.MapPath(savePath), fileUpload.FileName));
            }
            dmspdb.TenDM = dmsp.TenDM;
            data.SubmitChanges();
            return RedirectToAction("Danhmuc");
        }


        public ActionResult Delete(int id)
        {
            var D_ND = data.DANHMUCSANPHAMs.First(m => m.IdDM == id);
            return View(D_ND);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_ND = data.DANHMUCSANPHAMs.Where(m => m.IdDM == id).First();
            data.DANHMUCSANPHAMs.DeleteOnSubmit(D_ND);
            data.SubmitChanges();
            return RedirectToAction("Danhmuc");
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DANHMUCSANPHAM dm, HttpPostedFileBase fileUpload)
        {
            if (fileUpload != null)
            {
                dm.HinhAnh = savePath + fileUpload.FileName;
                fileUpload.SaveAs(Path.Combine(Server.MapPath(savePath), fileUpload.FileName));
            }
            data.DANHMUCSANPHAMs.InsertOnSubmit(dm);
            data.SubmitChanges();
            return RedirectToAction("Danhmuc");
        }

    }
}   