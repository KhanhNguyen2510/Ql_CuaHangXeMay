using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DAO;
using DoAN.DTO;

namespace DoAN.BUS
{
    class xem_bus
    {
        public static List<NhanVien_DTO> getdsnv()
        {
            return NhanVien_DAO.dsXe();
        }
        public static List<NhanVien_DTO> gedsncc()
        {
            return NhanVien_DAO.dsNCC();
        }

    }
}
