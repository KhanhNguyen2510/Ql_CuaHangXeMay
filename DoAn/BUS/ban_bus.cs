using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DAO;
using DoAN.DTO;

namespace DoAN.BUS
{
    class ban_bus
    {

        public static int THemBan(string id, string xe, string number, string date, string thanhtien, string kh)
        {
            return HDNhap.ThemBan(id, xe, number, date, thanhtien, kh);
        }
        public static List<Ban> getdsnv()
        {
            return HDNhap.dsBan();
        }
        public static int XoanvBUS(string name)
        {
            return HDNhap.XoaBan(name);
        }
        public static int SuaNV(string id, string xe, string number, string date, string thanhtien)
        {
            return HDNhap.SuaBan(id, xe, number, date, thanhtien);
        }
    }
}
