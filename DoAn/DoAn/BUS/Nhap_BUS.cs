using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DAO;
using DoAN.DTO;

namespace DoAN.BUS
{
    class Nhap_BUS
    {
        public static int ThemNBUS(string id, string name, string ncc, string number, string date, string money)
        {
            return NhanVien_DAO.ThemNhap(id, name, ncc, number, date, money);
        }
        public static List<NhanVien_DTO> getdsnv()
        {
            return NhanVien_DAO.dsNhap();
        }
        public static int XoanvBUS(string name)
        {
            return NhanVien_DAO.XoaNhap(name);
        }
        public static int SuaNV( string id, string name, string ncc, string number, string date, string money)
        {
            return NhanVien_DAO.SuaNhap(id, name, ncc, number, date, money);
        }
    }
}
