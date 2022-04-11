using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VPP18.Models;

namespace VPP18.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();

        public string IdSP { get; set; }


        [Display(Name = "Tên sản phẩm")]
        public string TenSP { get; set; }

        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get; set; }

        [Display(Name = "Giá bán")]
        public Double GiaBan { get; set; }

        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }


        [Display(Name = "Thành tiền")]

        public Double ThanhTien { get { return (double)(SoLuong * GiaBan); } }
        public GioHang(string id)
        {
            IdSP = id;
            SANPHAM s = data.SANPHAMs.Single(n => n.IdSP == IdSP);
            TenSP = s.TenSP;
            HinhAnh = s.HinhAnh;
            GiaBan = double.Parse(s.DonGia.ToString());
            SoLuong = 1;
                    }
    }
}