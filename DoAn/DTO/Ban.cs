using System;
using System.Collections.Generic;
using System.Text;

namespace DoAN.DTO
{
    class Ban
    {
        private string id, xe, date, kh, nv, thanhtien;
        private int number;

        public string Id { get => id; set => id = value; }
        public string Xe { get => xe; set => xe = value; }

        public string Date { get => date; set => date = value; }

        public string Kh { get => kh; set => kh = value; }
        public int Number { get => number; set => number = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Nv { get => nv; set => nv = value; }
    }
}
