using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Employees
    {
        [Key]
        public long EmployeeID { get; set; }

        [StringLength(2147483647)]
        public string LastName { get; set; }

        [StringLength(2147483647)]
        public string FirstName { get; set; }

        [StringLength(2147483647)]
        public string Title { get; set; }

        [StringLength(2147483647)]
        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(2147483647)]
        public string Address { get; set; }

        [StringLength(2147483647)]
        public string City { get; set; }

        [StringLength(2147483647)]
        public string Region { get; set; }

        [StringLength(2147483647)]
        public string PostalCode { get; set; }

        [StringLength(2147483647)]
        public string Country { get; set; }

        [StringLength(2147483647)]
        public string HomePhone { get; set; }

        [StringLength(2147483647)]
        public string Extension { get; set; }

        [MaxLength(2147483647)]
        public byte[] Photo { get; set; }

        [StringLength(2147483647)]
        public string Notes { get; set; }

        public long? ReportsTo { get; set; }

        [StringLength(2147483647)]
        public string PhotoPath { get; set; }
    }
}