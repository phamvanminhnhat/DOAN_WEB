using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Areas.Admin.Controllers
{
    public class DanhMucController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
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
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_idDM = data.DANHMUCSANPHAMs.First(m => m.IdDM == id);
            var E_TenDM = collection["TenDM"];
            var E_Hinh = collection["HinhAnh"];
            

            E_idDM.IdDM = id;
            if (string.IsNullOrEmpty(E_TenDM))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_idDM.TenDM = E_TenDM;
                E_idDM.HinhAnh = E_Hinh;
                
                UpdateModel(E_idDM);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
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
            return RedirectToAction("Index");
        }

    }
}   