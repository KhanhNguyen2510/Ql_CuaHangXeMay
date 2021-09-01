using System;
using System.Collections.Generic;
using System.Text;

namespace DoAN.DTO
{
    class Ban
    {
        private string id, xe, number, date, thanhtien, kh;

        public string Id { get => id; set => id = value; }
        public string Xe { get => xe; set => xe = value; }
        public string Number { get => number; set => number = value; }
        public string Date { get => date; set => date = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Kh { get => kh; set => kh = value; }
    }
}
