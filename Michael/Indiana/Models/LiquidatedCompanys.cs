using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Indiana.Models
{
    public partial class LiquidatedCompanys
    {
        [Key]
        public string Usdot { get; set; }
        public string LegalName { get; set; }
        public string Dbaname { get; set; }
        public string Address { get; set; }
        public string Oosreason { get; set; }
        public string Oosdate { get; set; }
        public string Status { get; set; }
        public string GeoLocation { get; set; }
        public string AddminId { get; set; }
    }
}
