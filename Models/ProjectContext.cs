using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LarsenNToubro.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Opportunity> Opportunity { get; set; }

        public DbSet<Contact_Details> Contact_Details { get; set; }

        public DbSet<Industry_Records> Industry_Records { get; set; }

        public DbSet<Company_Information> Company_Information { get; set; }

        public DbSet<Lt_Ts_Operations> Lt_Ts_Operations { get; set; }

        public DbSet<Contact_History>  Contact_History { get; set; }
        
        public DbSet<Login_Page> Login_Page { get; set; }
    }
}