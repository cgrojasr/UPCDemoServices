using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UPC.Demo.BE;

namespace UPC.Demo.DA
{
    public interface IProductDA {
        IEnumerable<ProductBE> AllActiveProducts();
        ProductBE GetProductById(int id);
        ProductBE SetProduct(ProductBE objProductBE);
        ProductBE UpdateProduct(ProductBE objProductBE);
    }

    public class ProductDA : IProductDA
    {
        private readonly dmUPCDemoDataContext db;
        public ProductDA()
        {
            this.db = new dmUPCDemoDataContext();
        }

        public IEnumerable<ProductBE> AllActiveProducts()
        {
            try
            {
                var query = from product in db.products
                            where product.active
                            select new ProductBE
                            {
                                Id = product.id,
                                Title = product.title,
                                Description = product.description,
                                Image = product.title,
                                Price = product.price
                            };

                return query;
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
                var query = from product in db.products
                            where product.active && product.id.Equals(id)
                            select new ProductBE {
                                Id = product.id,
                                Title = product.title,
                                Description = product.description,
                                Image = product.image,
                                Price = product.price
                            };

                return query.Single();
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
                product dbProduct = new product();
                dbProduct.id = objProductBE.Id;
                dbProduct.title = objProductBE.Title;
                dbProduct.description = objProductBE.Description;
                dbProduct.price = objProductBE.Price;
                dbProduct.image = objProductBE.Image;
                dbProduct.active = true;
                dbProduct.idUserCreated = objProductBE.UserId;
                dbProduct.dateCreated = DateTime.Now;

                db.products.InsertOnSubmit(dbProduct);
                db.SubmitChanges();

                objProductBE.Id = dbProduct.id;
                return objProductBE;
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
                product objProduct = db.products.Single(x => x.id.Equals(objProductBE.Id));

                objProduct.description = objProductBE.Description;
                objProduct.title = objProductBE.Title;
                objProduct.price = objProductBE.Price;
                objProduct.image = objProductBE.Image;
                objProduct.active = objProductBE.Active;
                objProduct.idUserModify = objProductBE.UserId;
                objProduct.dateModify = DateTime.Now;

                db.SubmitChanges();

                return objProductBE;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
