namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        [Key]
        public long CategoryID { get; set; }

        [StringLength(2147483647)]
        public string CategoryName { get; set; }

        [StringLength(2147483647)]
        public string Description { get; set; }

        [MaxLength(2147483647)]
        public byte[] Picture { get; set; }
    }
}
