namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Products Above Average Price")]
    public partial class Products_Above_Average_Price
    {
        [Key]
        [StringLength(2147483647)]
        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
    }
}
