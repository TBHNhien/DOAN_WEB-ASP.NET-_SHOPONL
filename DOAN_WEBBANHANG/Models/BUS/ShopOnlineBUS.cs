using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOAN_WEBBANHANG.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopOnlineConnectionDB();

            if (a == null)
            {
                a = "SP1";
            }

            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham = @0", a);
        }
    }
}