using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("Orders Qry")]
    public class Orders_Qry
    {
        [Key]
        public long OrderID { get; set; }

        [StringLength(2147483647)]
        public string CustomerID { get; set; }

        public long? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public long? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        [StringLength(2147483647)]
        public string ShipName { get; set; }

        [StringLength(2147483647)]
        public string ShipAddress { get; set; }

        [StringLength(2147483647)]
        public string ShipCity { get; set; }

        [StringLength(2147483647)]
        public string ShipRegion { get; set; }

        [StringLength(2147483647)]
        public string ShipPostalCode { get; set; }

        [StringLength(2147483647)]
        public string ShipCountry { get; set; }

        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string Address { get; set; }

        [StringLength(2147483647)]
        public string City { get; set; }

        [StringLength(2147483647)]
        public string Region { get; set; }

        [StringLength(2147483647)]
        public string PostalCode { get; set; }

        [StringLength(2147483647)]
        public string Country { get; set; }
    }
}