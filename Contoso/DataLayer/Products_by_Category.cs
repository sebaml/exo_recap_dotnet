namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Products by Category")]
    public partial class Products_by_Category
    {
        [StringLength(2147483647)]
        public string CategoryName { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string ProductName { get; set; }

        [StringLength(2147483647)]
        public string QuantityPerUnit { get; set; }

        public long? UnitsInStock { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string Discontinued { get; set; }
    }
}
