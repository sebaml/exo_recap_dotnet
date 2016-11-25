using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataModel;

namespace DataRequest
{
    public class ProductRequest
    {
        public static List<ProductDetail> ReqGetProducts(string name, long? supplierId, long? categoryId, bool inStock,
            bool discontinued)
        {
            using (var context = new ContosoContext())
            {
                var products = context.Products.ToList();
                if (name != null)
                    products = products.Where(p => p.ProductName.Contains(name)).ToList();
                if (supplierId != null)
                    products = products.Where(p => p.SupplierID == supplierId).ToList();
                if (categoryId != null)
                    products = products.Where(p => p.CategoryID == categoryId).ToList();
                products = inStock
                    ? products.Where(p => p.UnitsInStock > 0).ToList()
                    : products.Where(p => p.UnitsInStock == 0).ToList();
                products = discontinued
                    ? products.Where(p => p.Discontinued.Equals("1")).ToList()
                    : products.Where(p => p.Discontinued.Equals("0")).ToList();


                return products.Select(p => new ProductDetail
                {
                    CategoryId = p.CategoryID,
                    Discontinued = p.Discontinued,
                    ProductId = p.ProductID,
                    ProductName = p.ProductName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    ReorderLevel = p.ReorderLevel,
                    SupplierId = p.SupplierID,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder
                }).ToList();
            }
        }

        public static ProductDetail ReqGetProductById(long productId)
        {
            using (var context = new ContosoContext())
            {
                var product = context.Products.Single(p => p.ProductID == productId);
                return new ProductDetail
                {
                    CategoryId = product.CategoryID,
                    Discontinued = product.Discontinued,
                    ProductId = product.ProductID,
                    ProductName = product.ProductName,
                    QuantityPerUnit = product.QuantityPerUnit,
                    ReorderLevel = product.ReorderLevel,
                    SupplierId = product.SupplierID,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    UnitsOnOrder = product.UnitsOnOrder
                };
            }
        }

        public static bool ReqDelProduct(long id)
        {
            using (var context = new ContosoContext())
            {
                var product = context.Products.Single(p => p.ProductID == id);
                context.Products.Remove(product);
                context.SaveChanges();
                return !context.Products.Any(p => p.ProductID == id);
            }
        }

        public static bool ReqUpdateProduct(ProductDetail pd)
        {
            using (var context = new ContosoContext())
            {
                var product = context.Products.Single(p => p.ProductID == pd.ProductId);
                product.CategoryID = pd.CategoryId;
                product.Discontinued = pd.Discontinued;
                product.ProductID = pd.ProductId;
                product.ProductName = pd.ProductName;
                product.QuantityPerUnit = pd.QuantityPerUnit;
                product.ReorderLevel = pd.ReorderLevel;
                product.SupplierID = pd.SupplierId;
                product.UnitPrice = pd.UnitPrice;
                product.UnitsInStock = pd.UnitsInStock;
                product.UnitsOnOrder = pd.UnitsOnOrder;       
                context.SaveChanges();
                return true;
            }
        }

        public static bool ReqAddProduct(ProductDetail pd)
        {
            using (var context = new ContosoContext())
            {
                var product = new Products
                {
                    CategoryID = pd.CategoryId,
                    Discontinued = pd.Discontinued,
                    ProductID = pd.ProductId,
                    ProductName = pd.ProductName,
                    QuantityPerUnit = pd.QuantityPerUnit,
                    ReorderLevel = pd.ReorderLevel,
                    SupplierID = pd.SupplierId,
                    UnitPrice = pd.UnitPrice,
                    UnitsInStock = pd.UnitsInStock,
                    UnitsOnOrder = pd.UnitsOnOrder
                };
                context.Products.Add(product);
                context.SaveChanges();
                return true;
            }
        }



    }
}
