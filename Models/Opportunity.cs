using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LarsenNToubro.Models
{
    [Table("Opportunity")]
    public class Opportunity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Please enter opportunity_id")]
        public int Opportunity_id { get; set; }

        [Required(ErrorMessage ="Please enter date")]
        [DataType(DataType.Date)]
        public DateTime O_date { get; set;}

        [Required(ErrorMessage = "Please enter status.")]
        public string Opportunity_status { get; set; }

        [Required(ErrorMessage = "Please enter the opportunity description.")]
        public string Opportunity_description { get; set; }

        [Required(ErrorMessage = "Please enter the opportunity value.")]
        public string Opportunity_value { get; set; }

        [Required(ErrorMessage = "Please enter the opportunity domain.")]
        public string Opportunity_domain { get; set; }

        [Required(ErrorMessage = "Please enter the opportunity owner.")]
        public string Opportunity_owner_delivery { get; set; }

        [Required(ErrorMessage = "Please enter the opportunity owner.")]
        public string Opportunity_owner_sales { get; set; }
    }
}