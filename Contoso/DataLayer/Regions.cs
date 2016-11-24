namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Regions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RegionID { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string RegionDescription { get; set; }
    }
}
