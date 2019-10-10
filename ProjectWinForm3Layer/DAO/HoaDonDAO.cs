using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWinForm3Layer.DTO;
using static ProjectWinForm3Layer.DTO.HoaDonDTO;
namespace ProjectWinForm3Layer.DAO
{
    class HoaDonDAO
    {
        static QUANLYBANHANGEntities content = new QUANLYBANHANGEntities();

        public static void createHoaDon(HoaDonDTO hd)
        {
            var hdentity = new HoaDon();
            hdentity.MaHD = hd.MaHD ;
            hdentity.MaKH = hd.MaHD ;
            hdentity.MaNV = hd.MaNV ;
            hdentity.ThanhTien = hd.ThanhTien ;
            content.HoaDons.Add(hdentity);
            content.SaveChanges();
        }
    }
}
