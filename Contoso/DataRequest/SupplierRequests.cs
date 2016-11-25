using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataModel;

namespace DataRequest
{
    public class SupplierRequests
    {
        public static List<SupplierType> ReqGetSupplierByName(string name)
        {
            using (var context = new ContosoContext())
            {
                var suppliers = context.Suppliers.Where(s => s.CompanyName.Contains(name));
                return suppliers.Select(s => new SupplierType
                {
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    ContactTitle = s.ContactTitle,
                    Country = s.Country,
                    SupplierId=s.SupplierID

                }).ToList();
            }
        }

        public static List<SupplierType> ReqGetSuppliers()
        {
            using (var context = new ContosoContext())
            {
                var suppliers = context.Suppliers;
                return suppliers.Select(s => new SupplierType
                {
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    ContactTitle = s.ContactTitle,
                    Country = s.Country,
                    SupplierId = s.SupplierID

                }).ToList();
            }
        }

        public static SupplierDetail ReqGetSupplierDetail(long id)
        {
            using (var context = new ContosoContext())
            {
                var supplier = context.Suppliers.Single(s => s.SupplierID == id);
                return new SupplierDetail
                {
                    CompanyName = supplier.CompanyName,
                    ContactName = supplier.ContactName,
                    ContactTitle = supplier.ContactTitle,
                    Country = supplier.Country,
                    SupplierId = supplier.SupplierID,
                    Address = supplier.Address,
                    City = supplier.City,
                    Fax = supplier.Fax,
                    Region = supplier.Region,
                    Tel = supplier.Phone
                };
            }
        }

        public static bool ReqDelSupplier(long id)
        {
            using (var context = new ContosoContext())
            {
                var supplier = context.Suppliers.Single(s => s.SupplierID == id);
                context.Suppliers.Remove(supplier);
                context.SaveChanges();
                return !context.Suppliers.Any(s => s.SupplierID == id);
            }
        }

        public static bool ReqUpdateSupplier(SupplierDetail sd)
        {
            using (var context = new ContosoContext())
            {
                var supplier = context.Suppliers.Single(s => s.SupplierID == sd.SupplierId);
                supplier.Address = sd.Address;
                supplier.City = sd.City;
                supplier.Fax = sd.Fax;
                supplier.Phone = sd.Tel;
                supplier.Region = sd.Region;
                supplier.CompanyName = sd.CompanyName;
                supplier.Country = sd.Country;
                supplier.ContactTitle = sd.ContactName;
                supplier.HomePage = sd.Website;
                supplier.ContactName = sd.ContactName;
                context.SaveChanges();
                return true;
            }
        }

        public static bool ReqAddSupplier(SupplierDetail sd)
        {
            using (var context = new ContosoContext())
            {
                var supplier = new Suppliers
                {
                    SupplierID = sd.SupplierId,
                    ContactName = sd.ContactName,
                    Fax = sd.Fax,
                    City = sd.City,
                    Region = sd.Region,
                    Phone = sd.Tel,
                    Address = sd.Address,
                    ContactTitle = sd.ContactTitle,
                    CompanyName = sd.CompanyName,
                    Country = sd.Country,
                    HomePage = sd.Website
                };
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                return true;
            }
        }
    }
}