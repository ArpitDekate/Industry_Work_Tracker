using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LarsenNToubro.Models
{
    [Table("contact_history")]
    public class Contact_History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Opportunity_ID { get; set; }

        public string Contact_Person { get; set; }

        public string Status { get; set; }

        public string Contact_ID { get; set; }

        public Boolean Prob_Conversion_100 { get; set; }
        public Boolean Prob_Conversion_gt80 { get; set; }
        public Boolean Prob_Conversion_gt50 { get; set; }
        public Boolean Prob_Conversion_lt50 { get; set; }

        public string Conversation_Summary { get; set; }

        public string Contact_Type { get; set; }

        public string Corresponding_Type { get; set; }

        public int Proposal_Value { get; set; }

        public DateTime Contact_Date { get; set; }

        public string Contacted_By { get; set; }

        public Boolean Sales { get; set; }
        public string Sales_AD { get; set; }
        public string Sales_AO { get; set; }
        public DateTime Sales_ADO { get; set; }
        public DateTime Sales_CO { get; set; }

        public Boolean Edp { get; set; }
        public string Edp_AD { get; set; }
        public string Edp_AO { get; set; }
        public DateTime Edp_ADO { get; set; }
        public DateTime Edp_CO { get; set; }

        public Boolean Hor { get; set; }
        public string Hor_AD { get; set; }
        public string Hor_AO { get; set; }
        public DateTime Hor_ADO { get; set; }
        public DateTime Hor_CO { get; set; }

        public string Folder_Path { get; set; }
        public string Client_Name { get; set; }
        public string Sub_Division { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public string Sales_Region { get; set; }
        public DateTime Next_Contact_Date { get; set; }
        public string Appointment_Fixed_For { get; set; }
        public string Remarks { get; set; }
    }
}