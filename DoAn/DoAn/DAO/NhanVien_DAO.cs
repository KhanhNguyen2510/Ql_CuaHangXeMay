using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DTO;

namespace DoAN.DAO
{
    class NhanVien_DAO
    {
        public static int ThemNhap(string id, string name, string ncc, string number, string date, string money)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "create (n:NHAP{id:$id,name:$name,ncc:$ncc,number:$number,date:$date,money:$money})" +
                " with n Match (ch:CUAHANG),(cc:NCC),(nv:NHANVIEN) where  and nv.id='NV1' and n.ncc=cc.id" +
                " create (n)-[:Của_hàng]->(ch) create (n)-[:Nhà_cung_cấp]->(cc) create (nv)-[:Nhận_hàng]->(n)";
            neo4j.Excutequery(query, new { id, name, ncc, number, date, money });
            neo4j.CloseAsync();
            return 1;
        }

        public static int XoaNhap(string id)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string DeleteQ = "match (n:NHAP) where n.id=$id DETACH delete n";
            neo4j.Excutequery(DeleteQ, new { id });
            neo4j.CloseAsync();
            return 1;
        }

        public static int SuaNhap(string id,string name, string ncc, string number, string date, string money)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match (n:NHAP{id:$id}) set  n.number=$number,n.money=$money,n.name=$name,n.ncc=$ncc,n.date=$date";
            neo4j.Excutequery(query, new {id, name, ncc, number, date, money });
            neo4j.CloseAsync();
            return 1;
        }
        public static int login(string tk, string mk)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = ""

            return 1;
        }

        public static List<NhanVien_DTO> dsNhap()
        {
            List<NhanVien_DTO> ds = new List<NhanVien_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:NHAP) return n.id as ID, n.name as Name, n.ncc as NCC, n.date as Date, n.number as so, n.money as tien order by Name ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Ncc = x["NCC"].ToString();
                nv.Date = x["Date"].ToString();
                nv.Number = x["so"].ToString();
                nv.Money = x["tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }

        public static List<NhanVien_DTO> dsXe()
        {
            List<NhanVien_DTO> ds = new List<NhanVien_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:XE) return n.id as ID, n.name as Name, n.nsx as NCC, n.year as Date, n.money as tien order by Name ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Ncc = x["NCC"].ToString();
                nv.Date = x["Date"].ToString();
                nv.Money = x["tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }
        public static List<NhanVien_DTO> dsNCC()
        {
            List<NhanVien_DTO> ds = new List<NhanVien_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:NCC) return n.id as ID, n.name as Name, n.From as From order by Name ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Ncc = x["From"].ToString();
                ds.Add(nv);
            }
            return ds;
        }

       
    }
}
