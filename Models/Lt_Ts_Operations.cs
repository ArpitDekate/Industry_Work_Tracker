using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LarsenNToubro.Models
{
    public class Lt_Ts_Operations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_id { get; set; }

        public string Domain_category { get; set; }

        public string ADM { get; set; }

        public string ARM_sales { get; set; }

        public string Pre_sales { get; set; }

        public string Remarks1 { get; set; }
    }
}