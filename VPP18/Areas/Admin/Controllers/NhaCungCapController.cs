using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Areas.Admin.Controllers
{
    public class NhaCungCapController : Controller
    {
        string savePath = "/Content/images/";
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult ListNhaCungCap()
        {
            var lstNCC = data.NCCs.ToList();
            return View(lstNCC);

        }
        public ActionResult Detail(int id)
        {
            var D_NCC = data.NCCs.Where(m => m.IdNCC == id).First();
            return View(D_NCC);

        }
        public ActionResult Edit(int id)
        {
            var E_ND = data.NCCs.First(m => m.IdNCC == id);
            return View(E_ND);
        }
        [HttpPost]
        public ActionResult Edit(NCC dmsp, HttpPostedFileBase fileUpload)
        {
            var dmspdb = data.NCCs.FirstOrDefault(m => m.IdNCC == dmsp.IdNCC);
            if (fileUpload != null)
            {
                System.IO.File.Delete(Path.Combine(Server.MapPath(savePath), dmspdb.HinhAnh.Replace(savePath, "")));
                dmspdb.HinhAnh = savePath + fileUpload.FileName;
                fileUpload.SaveAs(Path.Combine(Server.MapPath(savePath), fileUpload.FileName));
            }
            dmspdb.TenNCC = dmsp.TenNCC;
            data.SubmitChanges();
            return RedirectToAction("ListNhaCungCap");
        }


        public ActionResult Delete(int id)
        {
            var D_NCC = data.NCCs.First(m => m.IdNCC == id);
            return View(D_NCC);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_NCC = data.NCCs.Where(m => m.IdNCC == id).First();
            data.NCCs.DeleteOnSubmit(D_NCC);
            data.SubmitChanges();
            return RedirectToAction("ListNhaCungCap");
        }


        // GET: Admin/NhaCungCap

        public ActionResult Create()
        {
            ViewBag.categories = data.NCCs.ToList();
            ViewBag.suppliers = data.NCCs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(SANPHAM sp, HttpPostedFileBase fileUpload)
        {
            if (fileUpload != null)
            {
                string fileName = fileUpload.FileName;
                sp.HinhAnh = fileName;
                fileUpload.SaveAs(Path.Combine(Server.MapPath(savePath), fileName));
            }
            data.SANPHAMs.InsertOnSubmit(sp);
            data.SubmitChanges();
            return RedirectToAction("ListNhaCungCap");
        }

    }
}