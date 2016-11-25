using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using DataModel;

namespace ServicesLayer
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<ProductDetail> GetProducts(string name, long? supplierId, long? categoryId, bool inStock, bool discontinued);

        [OperationContract]
        ProductDetail GetProductById(long productId);

        [OperationContract]
        bool DelProduct(long id);

        [OperationContract]
        bool UpdateProduct(ProductDetail pd);

        [OperationContract]
        bool AddProduct(ProductDetail pd);
    }
}