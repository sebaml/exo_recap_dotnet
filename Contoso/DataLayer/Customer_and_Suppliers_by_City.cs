namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer and Suppliers by City")]
    public partial class Customer_and_Suppliers_by_City
    {
        [StringLength(2147483647)]
        public string City { get; set; }

        [Key]
        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string ContactName { get; set; }
    }
}
