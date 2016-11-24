namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product Sales for 1997")]
    public partial class Product_Sales_for_1997
    {
        [StringLength(2147483647)]
        public string CategoryName { get; set; }

        [Key]
        [StringLength(2147483647)]
        public string ProductName { get; set; }
    }
}
