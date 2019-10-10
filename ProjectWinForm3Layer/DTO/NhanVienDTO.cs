using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWinForm3Layer.DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinhNV { get; set; }
        public string ChucVu { get; set; }
        public string TK_NhanVien { get; set; }
        public string MK_NhanVien { get; set; }
        public bool BiXoa { get; set; }
    }
}
