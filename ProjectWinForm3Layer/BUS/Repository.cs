using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWinForm3Layer.DAO;
using ProjectWinForm3Layer.DTO;

namespace ProjectWinForm3Layer.BUS
{
    class Repository
    {
        #region NhanVien
        public static List<NhanVienDTO> GetAllNhanVien() => NhanVienDAO.GetAllNhanVien();
        public static NhanVienDTO BindingNhanVien(int iMaNV) => NhanVienDAO.BindingNhanVien(iMaNV);
        public static void InsertNhanVien(NhanVienDTO nv) => NhanVienDAO.InsertNhanVien(nv);
        public static void UpdateNhanVien(NhanVienDTO nv) => NhanVienDAO.UpdateNhanVien(nv);
        public static void DeleteNhanVien(int id) => NhanVienDAO.DeleteNhanVien(id);
        #endregion

        #region Kho

        public static List<SanPhamDTO> GetAllKho() => SanPhamDAO.GetAllKho();
        public static void InsertUpdateKho(SanPhamDTO kho) => SanPhamDAO.InsertUpdateKho(kho);
        public static void DeleteKho(string id) => SanPhamDAO.DeleteKho(id);
        public static SanPhamDTO AddProduct(string id) => SanPhamDAO.AddProduct(id);

        #endregion

        #region HoaDon

        public static void CreateHoaDon(HoaDonDTO hd) => HoaDonDAO.createHoaDon(hd);

        #endregion
    }
}
