using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UPC.Demo.BE;
using UPC.Demo.BL;

namespace UPCDemoServices.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductBL objProductBL;
        public ProductController()
        {
            objProductBL = new ProductBL();
        }

        [HttpGet]
        public IEnumerable<ProductBE> AllActiveProducts()
        {
            return objProductBL.AllActiveProducts();
        }

        [HttpGet]
        public ProductBE GetProductById(int id)
        {
            return objProductBL.GetProductById(id);
        }

        [HttpPost]
        public ProductBE SetProduct([FromBody] ProductBE objProductBE)
        {
            return objProductBL.SetProduct(objProductBE);
        }

        [HttpPut]
        public ProductBE UpdateProduct([FromBody] ProductBE objProductBE)
        {
            return objProductBL.UpdateProduct(objProductBE);
        }
    }
}
