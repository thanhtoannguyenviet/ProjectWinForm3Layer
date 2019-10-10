using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWinForm3Layer.DTO;
namespace ProjectWinForm3Layer.DAO
{
    class NhanVienDAO
    {
       static QUANLYBANHANGEntities content = new QUANLYBANHANGEntities();

        public static List<NhanVienDTO> GetAllNhanVien()
        {
            var q = content.NHANVIENs.Select(t=> new NhanVienDTO{MaNV = t.MANV,TenNV = t.TENNV,ChucVu = t.CHUCVU,GioiTinhNV = t.GIOITINH,BiXoa =(bool) t.BIXOA,TK_NhanVien = t.TK_NHANVIEN,MK_NhanVien = t.MK_NHANVIEN});
            return q.ToList();
        }
        public static NhanVienDTO BindingNhanVien(int iMaNV)
        {
            var q = content.NHANVIENs.Where(t=>t.MANV==iMaNV).Select(t => new NhanVienDTO { MaNV = t.MANV, TenNV = t.TENNV, ChucVu = t.CHUCVU, GioiTinhNV = t.GIOITINH, BiXoa = (bool)t.BIXOA, TK_NhanVien = t.TK_NHANVIEN, MK_NhanVien = t.MK_NHANVIEN });
            return q.FirstOrDefault();
        }

        public static void InsertNhanVien(NhanVienDTO nv)
        {
            NHANVIEN entity = new NHANVIEN();
            entity.MANV = nv.MaNV;
            entity.TENNV = nv.TenNV;
            entity.CHUCVU = nv.ChucVu;
            entity.BIXOA = nv.BiXoa;
            entity.GIOITINH = nv.GioiTinhNV;
            entity.TK_NHANVIEN = nv.TK_NhanVien;
            entity.MK_NHANVIEN = nv.MK_NhanVien;
            content.NHANVIENs.Add(entity);
            content.SaveChanges();
        }
        public static void UpdateNhanVien(NhanVienDTO nv)
        {
            var entity = content.NHANVIENs.Where(s=>s.MANV==nv.MaNV).FirstOrDefault();
            if (entity != null) { 
                entity.MANV = nv.MaNV;
                entity.TENNV = nv.TenNV;
                entity.CHUCVU = nv.ChucVu;
                entity.BIXOA = nv.BiXoa;
                entity.GIOITINH = nv.GioiTinhNV;
                entity.TK_NHANVIEN = nv.TK_NhanVien;
                entity.MK_NHANVIEN = nv.MK_NhanVien;
                content.SaveChanges();
            }
        }

        public static void DeleteNhanVien(int id)
        {
            var entity = content.NHANVIENs.Where(s => s.MANV == id).FirstOrDefault();
            if (entity != null)
            {
                content.NHANVIENs.Remove(entity);
                content.SaveChanges();
            }
        }
    }
}
