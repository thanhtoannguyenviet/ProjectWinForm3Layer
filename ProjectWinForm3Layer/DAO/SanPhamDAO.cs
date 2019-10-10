using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWinForm3Layer.DTO;

namespace ProjectWinForm3Layer.DAO
{
    class SanPhamDAO
    {

        static QUANLYBANHANGEntities content = new QUANLYBANHANGEntities();
        public static List<SanPhamDTO> GetAllKho()
        {
            var q = content.SANPHAMs.Select(t => new SanPhamDTO
            {
                MaSP = t.MASP,TenSP = t.TENSP,SL = (int) t.SL,MaLoai = t.MALOAI,MaTH = t.MATH,GiaNhap = (int) t.GiaMua, GiaXuat = (int) t.GiaBan,LuotMua =(int) t.LUOTMUA,
                BiXoa = (bool) t.BIXOA,
                
            });
            return q.ToList();
        }

        public static void InsertUpdateKho(SanPhamDTO t)
        {
            var q = content.SANPHAMs.Where(k => k.MASP == t.MaSP).FirstOrDefault();
            if (q == null)
            {
                q=new SANPHAM
                {
                    MASP = t.MaSP,
                    TENSP = t.TenSP,
                    SL = (int)t.SL,
                    MALOAI= t.MaLoai,
                    MATH = t.MaTH,
                    GiaMua = (int)t.GiaNhap,
                    GiaBan = (int)t.GiaXuat,
                    LUOTMUA = t.LuotMua,
                    BIXOA = (bool)t.BiXoa,
                };
                content.SANPHAMs.Add(q);
                content.SaveChanges();
            }
            else
            {
                q = new SANPHAM
                {
                    MASP = t.MaSP,
                    TENSP = t.TenSP,
                    SL = (int)t.SL,
                    MALOAI = t.MaLoai,
                    MATH = t.MaTH,
                    GiaMua = (int)t.GiaNhap,
                    GiaBan = (int)t.GiaXuat,
                    LUOTMUA = t.LuotMua,
                    BIXOA = (bool)t.BiXoa,
                };
                content.SaveChanges();
            }
        }
        public static void DeleteKho(string id)
        {
            var entity = content.SANPHAMs.Where(k => k.MASP == id).FirstOrDefault();
            if (entity != null)
            {
                entity.BIXOA = true;
                content.SaveChanges();
            }
        }

        public static SanPhamDTO AddProduct(string txt)
        {
            var q = content.SANPHAMs.Where(k => k.MASP == txt).Select(t=> new SanPhamDTO { MaSP=t.MASP,TenSP=t.TENSP,SL=1,GiaXuat= (int)t.GiaBan});
            return q.FirstOrDefault();

        }
    }
}
