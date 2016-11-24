namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        [Key]
        [StringLength(2147483647)]
        public string CustomerID { get; set; }

        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string ContactName { get; set; }

        [StringLength(2147483647)]
        public string ContactTitle { get; set; }

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

        [StringLength(2147483647)]
        public string Phone { get; set; }

        [StringLength(2147483647)]
        public string Fax { get; set; }
    }
}
