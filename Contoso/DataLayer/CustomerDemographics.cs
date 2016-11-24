namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerDemographics
    {
        [Key]
        [StringLength(2147483647)]
        public string CustomerTypeID { get; set; }

        [StringLength(2147483647)]
        public string CustomerDesc { get; set; }
    }
}
