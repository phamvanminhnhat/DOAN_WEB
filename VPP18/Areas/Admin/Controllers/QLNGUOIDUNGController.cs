using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Areas.Admin.Controllers
{
    public class QLNGUOIDUNGController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Admin/QLNGUOIDUNG
        public ActionResult Index()
        {
            var lstND = data.NGUOIDUNGs.ToList();
            return View(lstND);
        
    }
        public ActionResult Detail(int id)
        {
            var D_ND = data.NGUOIDUNGs.Where(m => m.IdND == id).First();
            return View(D_ND);

        }
        public ActionResult Edit(int id)
        {
            var E_ND = data.NGUOIDUNGs.First(m => m.IdND == id);
            return View(E_ND);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_idND = data.NGUOIDUNGs.First(m => m.IdND == id);
            var E_TenND = collection["TenND"];
            
            var E_SDT = collection["SDT"];
            var E_Diachi = collection["DiaChi"];
            var E_email = collection["Email"];
            var E_MatKhau = collection["MatKhau"];

            E_idND.IdND = id;
            if (string.IsNullOrEmpty(E_TenND))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_idND.TenND = E_TenND;
                E_idND.SDT = E_SDT;
                E_idND.DiaChi = E_Diachi;
                E_idND.Email = E_email;
                E_idND.MatKhau = E_MatKhau;
                UpdateModel(E_idND);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }

        
        public ActionResult Delete(int id)
        {
            var D_ND = data.NGUOIDUNGs.FirstOrDefault(m => m.IdND == id);
            return View(D_ND);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_ND = data.NGUOIDUNGs.Where(m => m.IdND == id).First();
            data.NGUOIDUNGs.DeleteOnSubmit(D_ND);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }

    }
}