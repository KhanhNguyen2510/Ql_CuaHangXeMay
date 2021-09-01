using System;
using System.Collections.Generic;
using System.Text;

namespace DoAN.DTO
{
    class DSXE_DTO
    {

        private String id, nsx, name, phienban, money, year;
       
        

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Nsx { get => nsx; set => nsx = value; }
    
     
        public string Money { get => money; set => money = value; }
        public string Year { get => year; set => year = value; }
        public string Phienban { get => phienban; set => phienban = value; }
    }
}
