using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DTO;

namespace DoAN.DAO
{
    class NhanVien_DAO
    {
       
        public static int ThemNhap(string id, string name, int number, string date, string money)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "create(n:NHAP{id:$id,number:$number,date:$date,money:$money})" +
                " with n match(x:XE),(nv:NHANVIEN),(cc:NCC) where nv.id='NV1' and x.id=$name and cc.id=x.nsx" +
                " merge (n)-[:Lấy_hàng]->(cc) merge (n)-[:Nhập_xe]->(x) merge (nv)-[:Nhân_viên_nhập]->(n)";
            neo4j.Excutequery(query, new { id, name, number, date, money });
            neo4j.CloseAsync();
            return 1;
        }

        public static int ThemKH(string id, string name, string sdt, string add )
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "create (n1:KHACHHANG{id:$id,name:$name,sdt:$sdt,address:$add})";
            neo4j.Excutequery(query, new { id, name,sdt,add });
            neo4j.CloseAsync();
            return 1;
        }
        public static int Themxe(string id, string name, string nsx, string year, string money)
        {
            string t = @"""""";
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "merge (n:XE{id:$id,name:$name,nsx:$nsx,year:$year,money:$money,phienban:''})" +
                " with n match(m:NCC) where m.id=n.nsx merge (m)-[:Nhà_sản_xuất]->(n)";
            neo4j.Excutequery(query, new { id, name, nsx,year,money });
            neo4j.CloseAsync();
            return 1;
        }
        public static int ThemBan(string id, string xe, int number, string date, string thanhtien, string kh)
        {

           
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "merge(n:HDBAN{id:$id,date:$date,number:$number,thanhtien:$thanhtien}) " +
                "with n match (x:XE),(kh:KHACHHANG),(nv:NHANVIEN)" +
                " where nv.id='NV1' and x.id=$xe and kh.id=$kh" +
                " merge (nv)<-[:Nhân_viên_bán]-(n) merge (n)-[:Mua_xe]->(x) merge (kh)-[:Khách_hàng_mua]->(n)";
            neo4j.Excutequery(query, new { id, xe, number, date, thanhtien, kh });
            neo4j.CloseAsync();
            return 1;
        }

        public static int XoaNhap(string id)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string DeleteQ = "match (n:NHAP{id:$id}) DETACH delete n";
            neo4j.Excutequery(DeleteQ, new { id });
            neo4j.CloseAsync();
            return 1;
        }

        public static int CapnhatKHMua(string id,string nv)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string DeleteQ = "MATCH (n:HDBAN{id:$id})-[rel:Nhân_viên_bán]->()" +
                "MATCH (jennifer:NHANVIEN{id:$nv})" +
                "CALL apoc.refactor.to(rel, jennifer)" +
                "YIELD input, output " +
                "RETURN input, output; ";
            neo4j.Excutequery(DeleteQ, new { id,nv });
            neo4j.CloseAsync();
            return 1;
        }

        public static int SuaNhap(string id, int number)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match (n:NHAP{id:$id}) set number:$number";
            neo4j.Excutequery(query, new {id, number});
            neo4j.CloseAsync();
            return 1;
        }

        public static int XoaBan(string id)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string DeleteQ = "match (n:HDBAN{id:$id}) DETACH delete n";
            neo4j.Excutequery(DeleteQ, new { id });
            neo4j.CloseAsync();
            return 1;
        }

        public static int SuaBan(string id, int number)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match (n:HDBAN{id:$id}) set n.number=$number";
            neo4j.Excutequery(query, new { id, number });
            neo4j.CloseAsync();
            return 1;
        }

        public static List<NhanVien_DTO> dsNhap()
        {
            List<NhanVien_DTO> ds = new List<NhanVien_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:NHAP)-[r:Nhập_xe]->(m:XE)" +
                " return n.id as ID, n.date as Date, n.number as So, n.money as Tien , m.name as Name order by Name ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Date = x["Date"].ToString();
                nv.Number = Int32.Parse(x["So"].ToString());
                nv.Money =x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }
        public static List<NhanVien_DTO> Tangdan()
        {
            List<NhanVien_DTO> ds = new List<NhanVien_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:NHAP)-[r:Nhập_xe]->(m:XE)" +
                " return n.id as ID, m.name as Name, n.date as Date, n.number as So, n.money as Tien  order by Tien desc ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Date = x["Date"].ToString();
                nv.Number = Int32.Parse(x["So"].ToString());
                nv.Money = x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }

        public static List<NhanVien_DTO> Giamdan()
        {
            List<NhanVien_DTO> ds = new List<NhanVien_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:NHAP)-[r:Nhập_xe]->(m:XE)" +
                " return n.id as ID, m.name as Name, n.date as Date, n.number as So, n.money as Tien  order by Tien asc ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Date = x["Date"].ToString();
                nv.Number = Int32.Parse(x["So"].ToString());
                nv.Money = x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }

    
        public static List<DSXE_DTO> dsXe()
        {
            List<DSXE_DTO> ds = new List<DSXE_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:XE) return n.id as ID, n.name as Name, n.nsx as NCC, n.year as Date, n.money as Tien, n.phienban as Phienban ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                DSXE_DTO nv = new DSXE_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Nsx = x["NCC"].ToString();
                nv.Phienban = x["Phienban"].ToString();
                nv.Year = x["Date"].ToString();
                nv.Money =x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }


        public static List<DSXE_DTO> tenxe(string id)
        {
            List<DSXE_DTO> ds = new List<DSXE_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "MATCH (n:XE{id:$id}) RETURN n.money as Tien";
            var record = neo4j.ListRecordAsynctim(query,id);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                DSXE_DTO nv = new DSXE_DTO();
                nv.Money = x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }
        public static List<DSXE_DTO> TimkiemNangcao(string tim)
        {
            List<DSXE_DTO> ds = new List<DSXE_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "CALL apoc.search.multiSearchReduced({ XE: 'name'},'CONTAINS','$tim'); ";
            var record = neo4j.ListRecordAsynctim(query,tim);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                DSXE_DTO nv = new DSXE_DTO();
              
                nv.Name = x["name"].ToString();

                ds.Add(nv);
            }
            return ds;
        }
        public static int CHIEN(string id)
        {
            string t1 = @"""Phiên bản cũ""";
            string t2 = @"""Phiên bản mới""";
            string t3 = @"""Phiên bản bình thường""";
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match (n:XE{id:'ELB110'})" +
                 "CALL apoc.do.case([n.year>=1999 and n.year<2019,'set n.phienban=" + t1 + " return n'," +

               "n.year>=2019 and n.year<2021 ,'set n.phienban=" + t2 + " return n'],'set n.phienban=" + t3 + " return n',{n:n})" +
                 "YIELD value " +
                 "return n.id as ID, n.name as Name, n.nsx as NCC, n.year as Date, n.money as Tien, n.phienban as Phienban ";

            neo4j.Excutequery(query,id);
            neo4j.CloseAsync();
            return 1;
        }
       
        public static List<Dsncc_DTO> dsNCC()
        {
            List<Dsncc_DTO> ds = new List<Dsncc_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:NCC) return n.id as ID, n.name as Name, n.from as From  ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                Dsncc_DTO nv = new Dsncc_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.From = x["From"].ToString();
                ds.Add(nv);
            }
            return ds;
        }
        
        public static List<DSXE_DTO> Tim(string name)
        {
            List<DSXE_DTO> ds = new List<DSXE_DTO>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match (n:XE) where n.name STARTS WITH $name " +
                "or n.name CONTAINS $name " +
                "or n.name ENDS WITH $name  return n.id as ID, n.name as Name, n.nsx as NCC, n.year as Date, n.money as Tien, n.phienban as Phienban";
            var record = neo4j.ListRecordAsynctim(query,new { name });
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                DSXE_DTO nv = new DSXE_DTO();
                nv.Id = x["ID"].ToString();
                nv.Name = x["Name"].ToString();
                nv.Nsx = x["NCC"].ToString();
                nv.Phienban = x["Phienban"].ToString();
                nv.Year = x["Date"].ToString();
                nv.Money = x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }
        ////////////////////////////////////

        public static List<Ban> GiatriBan(string name)
        {
            List<Ban> ds = new List<Ban>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:HDBAN)-[r:Mua_xe]->(m:XE),(kh:KHACHHANG)-[:Khách_hàng_mua]->(n:HDBAN),(n:HDBAN)-[:Nhân_viên_bán]->(nv:NHANVIEN) " +
                "return n.id as ID, m.name as Xe, n.number as So, n.date as Date, n.thanhtien as Tien,kh.id as Ma,nv.id as Nhanvien order by So "+name+"";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                Ban nv = new Ban();
                nv.Id = x["ID"].ToString();
                nv.Xe = x["Xe"].ToString();
                nv.Kh = x["Ma"].ToString();
                nv.Nv = x["Nhanvien"].ToString();
                nv.Number = Int32.Parse(x["So"].ToString());
                nv.Date = x["Date"].ToString();
                nv.Thanhtien = x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }

        public static List<Ban> dsBan()
        {
            List<Ban> ds = new List<Ban>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:HDBAN)-[r:Mua_xe]->(m:XE),(kh:KHACHHANG)-[:Khách_hàng_mua]->(n:HDBAN),(n:HDBAN)-[:Nhân_viên_bán]->(nv:NHANVIEN) " +
                "return n.id as ID, m.name as Xe, n.number as So, n.date as Date, n.thanhtien as Tien,kh.id as Ma,nv.id as Nhanvien";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                Ban nv = new Ban();
                nv.Id = x["ID"].ToString();
                nv.Xe = x["Xe"].ToString();
                nv.Kh = x["Ma"].ToString();
                nv.Nv = x["Nhanvien"].ToString();
                nv.Number = Int32.Parse(x["So"].ToString());
                nv.Date = x["Date"].ToString();
                nv.Thanhtien = x["Tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }

    }
}
