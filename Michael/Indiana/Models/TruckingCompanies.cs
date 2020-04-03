using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Indiana.Models
{
    public partial class TruckingCompanies
    {
        [Key]
        public string Usdot { get; set; }
        public string LegalName { get; set; }
        public string Dbaname { get; set; }
        public string CarrierOperation { get; set; }
        public string HmFlag { get; set; }
        public string PcFlag { get; set; }
        public string PhyStreet { get; set; }
        public string PhyCity { get; set; }
        public string PhyState { get; set; }
        public string PhyZip { get; set; }
        public string PhyCountry { get; set; }
        public string MailingStreet { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingZip { get; set; }
        public string MailingCountry { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Mcs150Date { get; set; }
        public int Mcs150Mileage { get; set; }
        public string Mcs150MileageYear { get; set; }
        public string AddDate { get; set; }
        public string OicState { get; set; }
        public int NbrPowerUnit { get; set; }
        public int DriverTotal { get; set; }
        public string GeoLocation { get; set; }
        public string AddminId { get; set; }
    }
}
