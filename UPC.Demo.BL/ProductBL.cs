using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.Demo.BE;
using UPC.Demo.DA;

namespace UPC.Demo.BL
{
    public interface IProductoBL {
        IEnumerable<ProductBE> AllActiveProducts();
        ProductBE GetProductById(int id);
        ProductBE SetProduct(ProductBE objProductBE);
        ProductBE UpdateProduct(ProductBE objProductBE);
    }

    public class ProductBL : IProductoBL
    {
        private readonly ProductDA objProductDA;

        public ProductBL()
        {
            objProductDA = new ProductDA();
        }

        public IEnumerable<ProductBE> AllActiveProducts()
        {
            try
            {
                return objProductDA.AllActiveProducts();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProductBE GetProductById(int id)
        {
            try
            {
                return objProductDA.GetProductById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProductBE SetProduct(ProductBE objProductBE)
        {
            try
            {
                return objProductDA.SetProduct(objProductBE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProductBE UpdateProduct(ProductBE objProductBE)
        {
            try
            {
                return objProductDA.UpdateProduct(objProductBE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
