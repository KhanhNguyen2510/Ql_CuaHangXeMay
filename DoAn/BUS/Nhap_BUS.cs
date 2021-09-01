using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DAO;
using DoAN.DTO;

namespace DoAN.BUS
{
    class Nhap_BUS
    {
        public static int ThemNhap(string id, string name, int number, string date, string money)
        {
            return NhanVien_DAO.ThemNhap(id, name, number, date, money);
        }

        public static int Themkh(string id, string name, string sdt, string add)
        {
            return NhanVien_DAO.ThemKH(id, name, sdt, add);
        }
        public static List<NhanVien_DTO> getdsNhap()
        {
            return NhanVien_DAO.dsNhap();
        }
        public static List<NhanVien_DTO> getdstang()
        {
            return NhanVien_DAO.Tangdan();
        }


        public static List<NhanVien_DTO> getdsgiam()
        {
            return NhanVien_DAO.Giamdan();
        }
        public static int XoadsNhap(string id)
        {
            return NhanVien_DAO.XoaNhap(id);
        }

        public static int Themxeee(string id, string name, string nsx, string year, string money)
        {
            return NhanVien_DAO.Themxe(id, name, nsx, year, money);
        }
        public static int XoadsBan(string id)
        {
            return NhanVien_DAO.XoaBan(id);
        }
        public static int SuaNhap( string id, int number)
        {
            return NhanVien_DAO.SuaNhap(id, number);
        }
        public static List<DSXE_DTO> dsxemay()
        {
            return NhanVien_DAO.dsXe();
        }

        public static List<DSXE_DTO> tenxeeee(string id)
        {
            return NhanVien_DAO.tenxe(id);
        }
        public static List<Dsncc_DTO> gedsncc()
        {
            return NhanVien_DAO.dsNCC();
        }


        public static List<DSXE_DTO> gettim(string name)
        {
            return NhanVien_DAO.Tim(name);
        }



   

        public static int THemBan(string id, string xe, int number, string date, string thanhtien, string kh)
        {
            return NhanVien_DAO.ThemBan(id, xe, number, date, thanhtien, kh);
        }
        public static List<Ban> getdsban()
        {
            return NhanVien_DAO.dsBan();
        }

        public static List<Ban> GiatriBanhang(string name)
        {
            return NhanVien_DAO.GiatriBan(name);
        }

        public static int SuaKH(string id,string nv)
        {
            return NhanVien_DAO.CapnhatKHMua(id,nv);
        }
        public static int SuadsBan(string id,int number)
        {
            return NhanVien_DAO.SuaBan(id, number);
        }
    }
}
