using System;
using System.Collections.Generic;
using System.Text;
using DoAN.DTO;

namespace DoAN.DAO
{
    class HDNhap
    {
       public static int ThemBan(string id, string xe, string number, string date, string thanhtien, string kh)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "create(n:HDBAN{id:$id,xe:$name,number:$number,date:$date,thanhtien:$thanhtien})" +
                " with n match (m:XE),(nv:NHANVIEN),(k:KHACHHANG) where m.id=n.xe and k.name=$kh and nv.id='NV1' " +
                "create (k)-[:Mua_hàng]->(n) create (n)-[:Xe_bán]->(m) create (nv)-[:Người_bán]->(n)";
            neo4j.Excutequery(query, new { id,xe,number,date,thanhtien,kh });
            neo4j.CloseAsync();
            return 1;
        }

        public static int XoaBan(string id)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string DeleteQ = "match (n:HDBAN) where n.id=$id DETACH delete n";
            neo4j.Excutequery(DeleteQ, new { id });
            neo4j.CloseAsync();
            return 1;
        }

        public static int SuaBan(string id, string xe, string number, string date, string thanhtien)
        {
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match (n:HDBAN{id:$id}) set n.xe=$xe, n.number=$number, n.date=$date,n.thanhtien=$thanhtien";
            neo4j.Excutequery(query, new { id, xe, number, date, thanhtien });
            neo4j.CloseAsync();
            return 1;
        }

        public static List<Ban> dsBan()
        {
            List<Ban> ds = new List<Ban>();
            Connection neo4j = new Connection();
            neo4j.Open("neo4j", "nguyen");
            string query = "match(n:HDBAN) return n.id as ID, n.xe as Xe, n.number as so, n.date as Date, n.thanhtien as tien order by Xe ";
            var record = neo4j.ListRecordAsync(query);
            neo4j.CloseAsync();
            foreach (var x in record.Result)
            {
                Ban nv = new Ban();
                nv.Id = x["ID"].ToString();
                nv.Xe = x["Xe"].ToString();
                nv.Number = x["so"].ToString();
                nv.Date = x["Date"].ToString();
                nv.Thanhtien = x["tien"].ToString();
                ds.Add(nv);
            }
            return ds;
        }
    }
}

