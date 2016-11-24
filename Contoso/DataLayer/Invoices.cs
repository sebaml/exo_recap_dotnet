using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class Invoices
    {
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
        public string CustomerID { get; set; }

        [StringLength(2147483647)]
        public string CustomerName { get; set; }

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

        [Key]
        [Column(Order = 0)]
        public long OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string ShipperName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ProductID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2147483647)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal UnitPrice { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Quantity { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "real")]
        public double Discount { get; set; }

        public decimal? Freight { get; set; }
    }
}