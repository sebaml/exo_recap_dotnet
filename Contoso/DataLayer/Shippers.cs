namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shippers
    {
        [Key]
        public long ShipperID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CompanyName { get; set; }

        [StringLength(2147483647)]
        public string Phone { get; set; }
    }
}
