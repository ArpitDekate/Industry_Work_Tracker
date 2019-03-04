using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LarsenNToubro.Models
{
    public class Industry_Records
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_id { get; set; }

        public string Client_name { get; set; }

        public string Sub_division { get; set; }

        public int Client_code { get; set; }

        public string Address { get; set; }

        public string Parent { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City_town { get; set; }

        public string Sales_region { get; set; }

        [DataType(DataType.PhoneNumber)]
        public Int64 Contact_no { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Fax { get; set; }

        public string Website { get; set; }

        public Boolean Parent_org { get; set; }

        public Boolean Hq { get; set; }

        public Boolean Existing { get; set; }

        public Boolean Prospects { get; set; }

        public Boolean Subsidiaries { get; set; }
    }
}