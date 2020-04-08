using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Indiana.Models
{
    public partial class ChameleonCompanies
    {
        [Key]
        public string Usdot { get; set; }
        public string PercentOcham { get; set; }
        public string AddminId { get; set; }
        [NotMapped]
        public virtual TruckingCompanies TruckingCompanies { get; set; }
    }
}
