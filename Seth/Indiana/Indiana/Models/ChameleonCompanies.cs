using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Indiana.Models
{
    public partial class ChameleonCompanies
    {
        [Key]
        public string Usdot { get; set; }
        public string addminID { get; set; }
    }
}
