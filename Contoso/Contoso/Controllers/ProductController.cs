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
            var categoryServiceClient = new ServiceReference2.CategoryServiceClient();
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();

            List<string> listcategories=new List<string>();
            var lc= categoryServiceClient.GetCategories();
            foreach (var c in lc)
            {
                listcategories.Add(c.CategoryName);
            }

            if (listcategories.Count==0)
                listcategories.Add("no categories");

            List<string> listSuppliers = new List<string>();
            var ls = supplierServiceClient.GetSuppliers();
            foreach (var c in ls)
            {
                listSuppliers.Add(c.CompanyName);
            }

            if (listSuppliers.Count == 0)
                listSuppliers.Add("no categories");

            ViewBag.categories = listcategories;
            ViewBag.suppliers = listSuppliers;
            return View();
        }

        //Post
        [HttpPost]
        public ActionResult Index(string name,String listCategories,String listSuppliers, bool inStock, bool discontinued)
        {
            var productServiceClient = new ServiceReference3.ProductServiceClient();

            var response = new List<ProductDetailModel>();


            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();

            var categoryServiceClient = new ServiceReference2.CategoryServiceClient();
            long? supplierId;
            long? categoryId;
            try
            {
                supplierId = supplierServiceClient.GetSupplierByName(listCategories).Single().SupplierId;
            }
            catch (Exception e)
            {
                supplierId = null;
            }

            try
            {
                 categoryId = categoryServiceClient.GetCategoryByName(listSuppliers).Single().CategoryId;
            }
            catch (Exception e)
            {
                categoryId = null;
            }

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



            List<string> listcategories = new List<string>();
            var lc = categoryServiceClient.GetCategories();
            foreach (var c in lc)
            {
                listcategories.Add(c.CategoryName);
            }

            if (listcategories.Count == 0)
                listcategories.Add("no categories");

            List<string> listSuppliers2 = new List<string>();
            var ls = supplierServiceClient.GetSuppliers();
            foreach (var c in ls)
            {
                listSuppliers2.Add(c.CompanyName);
            }

            if (listSuppliers2.Count == 0)
                listSuppliers2.Add("no categories");

            ViewBag.categories = listcategories;
            ViewBag.suppliers = listSuppliers2;


            return View("Index", response);
        }

        /************************************ Adding Product ****************************************
 **************************************************************************************************************/
        public ActionResult AddProduct()
        {
            var product = new ProductDetailModel();
            return View(product);
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