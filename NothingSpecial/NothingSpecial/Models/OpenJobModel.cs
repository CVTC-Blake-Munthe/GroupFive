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
        // the Open Jobs Database, which will house all of the work orders data.

        // Client data
        [Key]
        public int JobID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Message { get; set; }
        
        // Tech data
        public string TechNotes { get; set; }
        public double Estimate { get; set; }
        public double FinalCost { get; set; }
        public bool WorkComplete { get; set; }
        public string AssetModel { get; set; }
        public string AssetType { get; set; }
    }
}