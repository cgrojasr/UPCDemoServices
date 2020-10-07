using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPC.Demo.BL;
using System.Linq;
using UPC.Demo.BE;

namespace UPC.Demo.UT
{
    [TestClass]
    public class ProductUT
    {
        readonly ProductBL objProductDA;
        public ProductUT()
        {
            objProductDA = new ProductBL();
        }

        [TestMethod]
        public void TestAllActiveProducts()
        {
            var lstProducts = objProductDA.AllActiveProducts();
            var cantidad = lstProducts.Count();
            Assert.Equals(cantidad, 1);
        }

        [TestMethod]
        public void TestGetProductById()
        {
            var obj = objProductDA.GetProductById(1);
            Assert.Equals(obj.Price, 199);
        }

        [TestMethod]
        public void TestSetProduct()
        {
            var obj = new ProductBE();

            obj.Description = "Camiseta Real Madrid 19/20";
            obj.Title = "Camiseta Real Madrid 19/20";
            obj.Price = 199;
            obj.UserId = 0;

            obj = objProductDA.SetProduct(obj);
            Assert.Equals(2, obj.Id);
        }

        [TestMethod]
        public void TestUpdateProduct()
        {
            var obj = new ProductBE();

            obj.Id = 2;
            obj.Description = "Camiseta Real Madrid 20/21";
            obj.Title = "Camiseta Real Madrid 20/21";
            obj.Price = 200;
            obj.Image = "https://drive.google.com/file/d/1bWHAee9tBk3wDK74_KXBgWPXpWwqr0oK/view?usp=sharing";
            obj.Active = false;
            obj.UserId = 0;

            obj = objProductDA.UpdateProduct(obj);
            Assert.Equals(2, obj.Id);
        }
    }
}
