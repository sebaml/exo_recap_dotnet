namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quarterly Orders")]
    public partial class Quarterly_Orders
    {
        [Key]
        [StringLength(2147483647)]
        public string CustomerID { get; set; }

        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string City { get; set; }

        [StringLength(2147483647)]
        public string Country { get; set; }
    }
}
