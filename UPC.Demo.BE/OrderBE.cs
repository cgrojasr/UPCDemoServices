using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Demo.BE
{
    public class OrderBE
    {
        public class Header {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string OrderNumber { get; set; }
            public string NumberCard { get; set; }
            public string Address { get; set; }
            public string Comment { get; set; }
            public int UserModifyId { get; set; }
            public bool Active { get; set; }
        }

        public class Body { 
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Descount { get; set; }
        }
    }
}
