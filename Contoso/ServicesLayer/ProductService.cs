using System.Collections.Generic;
using DataModel;
using DataRequest;

namespace ServicesLayer
{
    public class ProductService : IProductService
    {
        public List<ProductDetail> GetProducts(string name, long? supplierId, long? categoryId, bool inStock, bool discontinued)
        {
            return ProductRequest.ReqGetProducts(name, supplierId, categoryId, inStock, discontinued);
        }

        public ProductDetail GetProductById(long productId)
        {
            return ProductRequest.ReqGetProductById(productId);
        }

        public bool DelProduct(long id)
        {
            return ProductRequest.ReqDelProduct(id);
        }

        public bool UpdateProduct(ProductDetail pd)
        {
            return ProductRequest.ReqUpdateProduct(pd);
        }

        public bool AddProduct(ProductDetail pd)
        {
            return ProductRequest.ReqAddProduct(pd);
        }
    }
}