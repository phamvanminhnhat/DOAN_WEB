using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VPP18.Models;

namespace VPP18.Areas.Admin.Controllers
{
    public class NhaCungCapController : Controller
    {
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
            var E_NCC = data.NCCs.First(m => m.IdNCC == id);
            return View(E_NCC);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_idNCC = data.NCCs.First(m => m.IdNCC == id);
            var E_TenNCC = collection["TenNCC"];
            var E_HinhAnh = collection["HinhAnh"];
            var E_SDT = collection["SDT"];
            var E_diachi = collection["DiaChi"];
            

            E_idNCC.IdNCC = id;
            if (string.IsNullOrEmpty(E_TenNCC))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_idNCC.TenNCC = E_TenNCC;
                E_idNCC.HinhAnh = E_HinhAnh;
                E_idNCC.SDT = E_SDT;
                E_idNCC.DiaChi = E_diachi;
                
                UpdateModel(E_idNCC);
                data.SubmitChanges();
                return RedirectToAction("ListNhaCungCap");
            }
            return this.Edit(id);
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
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, NCC ncc)
        {
            var E_TenNCC = collection["TenNCC"];
            var E_hinhanh = collection["HinhAnh"];
            var E_SDT = collection["SDT"];
            var E_diachi = collection["DiaChi"];
            if (string.IsNullOrEmpty(E_TenNCC))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                ncc.TenNCC = E_TenNCC.ToString();
                ncc.HinhAnh = E_hinhanh.ToString();
                ncc.SDT = E_SDT.ToString();
                ncc.DiaChi= E_diachi.ToString();
                data.NCCs.InsertOnSubmit(ncc);
                data.SubmitChanges();
                return RedirectToAction("ListNhaCungCap");
            }
            return this.Create();
        }

    }
}