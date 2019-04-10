using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NothingSpecial.Models
{       
    [Table("OpenJobs")]
    public class OpenJobModel
    {
        // Setting up the class for the Open Jobs Database. This is used by the Entity Framework to build
        // the Open Jobs Database, which will house all of the work orders data. The [StringLength()] and [Required]
        // in the square brackets are used for input validation. However, this will not be the only line of defence against 
        // bad (or dangerous) user input. 

        // Client (Customer) data
        [Key]
        public int JobID { get; set; }

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }


        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [StringLength(10000)]
        public string Message { get; set; }
        
        // Technician data
        [StringLength(100000)]
        public string TechNotes { get; set; }

        public double Estimate { get; set; }
        public double FinalCost { get; set; }
        public bool WorkComplete { get; set; }
        public string AssetModel { get; set; }
        public string AssetType { get; set; }
    }
}