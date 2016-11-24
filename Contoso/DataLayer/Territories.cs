namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Territories
    {
        [Key]
        [StringLength(2147483647)]
        public string TerritoryID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string TerritoryDescription { get; set; }

        public long RegionID { get; set; }
    }
}
