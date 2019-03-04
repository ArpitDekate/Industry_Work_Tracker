using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LarsenNToubro.Models
{
    public class Company_Information
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_id { get; set; }

        public DateTime Founded_on { get; set; }

        public int No_of_employees { get; set; }

        public int Revenue { get; set; }

        public string Register_no { get; set; }

        public string Production_services { get; set; }

        public string Remarks { get; set; }
    }
}