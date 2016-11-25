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

        /************************************ Searching Supplier ****************************************
 * ************************************************************************************************************/

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


        /************************************ Adding Supplier ****************************************
         **************************************************************************************************************/
        public ActionResult AddSupplier()
        {
            var supplier=new SupplierTypeModel();
            return View(supplier);
        }


        [HttpPost]
        public ActionResult AddSupplier(SupplierTypeModel supplier)
        {
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();
            SupplierDetail newSupplier = new SupplierDetail
            {
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                ContactTitle = supplier.ContactTitle,
                Country = supplier.Country,
                Address = supplier.Address,
                City = supplier.City,
                Fax = supplier.Fax,
                Region = supplier.Region,
                Tel = supplier.Tel,
                Website = supplier.Website,
                
            };
            if (supplierServiceClient.AddSupplier(newSupplier))
            {
                Console.WriteLine("supplier a été ajouté");
                return View();

            }
            else
            {
                return View();
            }
        }

        /************************************ Editing Supplier ****************************************
* ************************************************************************************************************/

        public ActionResult Edit(long id)
        {
            Session["SupplierIdModified"] = id;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(SupplierTypeModel supplier)
        {
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();
            SupplierDetail newSupplier = new SupplierDetail
            {
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                ContactTitle = supplier.ContactTitle,
                Country = supplier.Country,
                Address = supplier.Address,
                City = supplier.City,
                Fax = supplier.Fax,
                Region = supplier.Region,
                Tel = supplier.Tel,
                Website = supplier.Website,

            };
            newSupplier.SupplierId = (long) Session["SupplierIdModified"];
 
            supplierServiceClient.UpdateSupplier(newSupplier);
            Session["SupplierIdModified"] = -1;
            return RedirectToAction("Index");
        }
        /************************************ Show Supplier Details ****************************************
* ************************************************************************************************************/


        public ActionResult Details(long id)
        {
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();
            var supplier=supplierServiceClient.GetSupplierDetail(id);

            SupplierTypeModel SupplierById = new SupplierTypeModel
            {
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                ContactTitle = supplier.ContactTitle,
                Country = supplier.Country,
                Address = supplier.Address,
                City = supplier.City,
                Fax = supplier.Fax,
                Region = supplier.Region,
                Tel = supplier.Tel,
                Website = supplier.Website,

            };
            SupplierById.SupplierId = id;

            return View(SupplierById);
        }

        /************************************ Delete Supplier ****************************************
* ************************************************************************************************************/

        public ActionResult Delete(long id)
        {
            var supplierServiceClient = new ServiceReference1.SupplierServiceClient();
            supplierServiceClient.DelSupplier(id);
            return RedirectToAction("Index");
        }



    }
}