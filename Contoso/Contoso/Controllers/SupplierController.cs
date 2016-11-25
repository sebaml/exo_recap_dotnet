using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;
using Contoso.ServiceReference1;

namespace Contoso.Controllers
{
    public class SupplierController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Post
        [HttpPost]
        public ActionResult Index(String name)
        {
            var suppliername = name;
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();

            List<SupplierTypeModel> response = new List<SupplierTypeModel>();

            List<ServiceReference1.SupplierType> listSuppliers = supplierServiceClient.GetSupplierByName(suppliername);

            if (listSuppliers == null)
            {
                Session["SupplierFound"] = 0;
                return View("Index");
            }
            else
            {
                foreach (var s in listSuppliers)
                {
                    SupplierTypeModel supplier = new SupplierTypeModel()
                    {
                        CompanyName = s.CompanyName,
                        SupplierId = s.SupplierId,
                        ContactName = s.ContactName,
                        ContactTitle = s.ContactTitle,
                        Country = s.Country,
                        ExtensionData = s.ExtensionData
                    };
                    response.Add(supplier);

                }
                Session["SupplierFound"] = 1;
                return View("Index", response);
            }
        }

        public ActionResult AddSupplier()
        {
            var supplier=new SupplierTypeModel();
            return View(supplier);
        }


        [HttpPost]
        public ActionResult AddSupplier(SupplierTypeModel supplier)
        {
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();
            return View();
        }

       


    }
}