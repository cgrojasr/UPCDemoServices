using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCDemoServices.Models
{
    public class Response<T>
    {
        public int code { get; set; } = 200;
        public string description { get; set; }
        public T response { get; set; }
    }
}