using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LarsenNToubro.Models
{
    [Table("Contact_Details")]
    public class Contact_Details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Opportunity_id { get; set; }

        public string Contact_Name { get; set; }

        public string Designation { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string LinkedIn { get; set; }
        
        public string Responsible_for { get; set; }

        public string Area { get; set; }

        public string Status { get; set; }

        public string Department { get; set; }

        [DataType(DataType.PhoneNumber)]
        public Int64 Mobile { get; set; }

        public Int64 Office_ph { get; set; }
    }
}