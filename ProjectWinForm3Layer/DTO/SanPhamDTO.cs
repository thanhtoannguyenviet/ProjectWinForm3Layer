using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWinForm3Layer.DTO
{
    class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SL { get; set; }
        public string MaLoai { get; set; }
        public string MaTH { get; set; }
        public int GiaNhap { get; set; }
        public int GiaXuat { get; set; }
        public int LuotMua { get; set; }
        public bool BiXoa { get; set; }
    }
}
