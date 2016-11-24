using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace DataRequest
{
    public class SupplierRequests
    {
        public static List<SupplierType> ReqGetSupplierByName(string name)
        {
            using (var context = new ContosoContext())
            {
                var suppliers = context.Suppliers.Where(s => s.CompanyName == name);
                return suppliers.Select(s => new SupplierType
                {
                    CompanyName = s.CompanyName, ContactName = s.ContactName, ContactTitle = s.ContactTitle, Country = s.Country
                }).ToList();
            }
        }

        public static SupplierDetail ReqGetSupplierDetail(long id)
        {
            using (var context = new ContosoContext())
            {
                var supplier = context.Suppliers.Single(s => s.SupplierID == id);
                return new SupplierDetail()
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
    }
}
