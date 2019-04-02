using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NothingSpecial.Models
{
    public class OpenJobsContext : DbContext
    {
        public DbSet<OpenJobModel> OpenJobs { get; set; }
    }
}