using System;
using System.Collections.Generic;
using System.Text;

namespace DoAN.DTO
{
    public class NhanVien_DTO
    {
        private string id;
        private string name;
        private string date;
        private int number;
        private string money;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public int Number { get => number; set => number = value; }
        public string Money { get => money; set => money = value; }
    }
}
