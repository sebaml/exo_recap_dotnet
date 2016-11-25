using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;
using Contoso.ServiceReference3;

namespace Contoso.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Post
        [HttpPost]
        public ActionResult Index(string name, long? supplierId, long? categoryId, bool inStock, bool discontinued)
        {
            var productServiceClient = new ServiceReference3.ProductServiceClient();

            var response = new List<ProductDetailModel>();

            var listProducts = productServiceClient.GetProducts(name, supplierId, categoryId, inStock, discontinued);

            if (!listProducts.Any())
            {
                Session["ProductFound"] = 0;
                return View("Index");
            }

            response.AddRange(listProducts.Select(s => new ProductDetailModel()
            {
                UnitsInStock = s.UnitsInStock, CategoryId = s.CategoryId, Discontinued = s.Discontinued, ProductName = s.ProductName, QuantityPerUnit = s.QuantityPerUnit,
                SupplierId = s.SupplierId, ReorderLevel = s.ReorderLevel, UnitPrice = s.UnitPrice, UnitsOnOrder = s.UnitsOnOrder
            }));
            Session["ProductFound"] = 1;
            
            return View("Index", response);
        }



        /* public ActionResult About()
         {
             ViewBag.Message = "Your application description page.";

             return View();
         }

         public ActionResult Contact()
         {
             ViewBag.Message = "Your contact page.";

             return View();
         }*/
    }
}