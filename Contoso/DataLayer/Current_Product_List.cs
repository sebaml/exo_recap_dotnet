namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Current Product List")]
    public partial class Current_Product_List
    {
        [Key]
        [Column(Order = 0)]
        public long ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string ProductName { get; set; }
    }
}
